using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.IO; //Работа с файлами
using System.Windows.Forms;
using System.Diagnostics; //StopWatch
using FANNCSharp; //Библиотека 
#if FANN_FIXED
	using FANNCSharp.Fixed;
	using DataType = System.Int32;
#elif FANN_DOUBLE
	using FANNCSharp.Double;
	using DataType = System.Double;
#else
using FANNCSharp.Float;
using DataType = System.Single;
#endif

namespace prDistinguishNumbers
{
    public partial class Form1 : Form
    {
        SolidBrush br = new SolidBrush(Color.Black);
        int currentX, currentY, pastX, pastY;
        Graphics gr, grF;
        Image[] masImages = new Image[15]{
            (Image)Properties.Resources.ResourceManager.GetObject("NOL"), //0
            (Image)Properties.Resources.ResourceManager.GetObject("ODI"), //1
            (Image) Properties.Resources.ResourceManager.GetObject("DVA"), //2
            (Image)Properties.Resources.ResourceManager.GetObject("TRI"), //3
            (Image)Properties.Resources.ResourceManager.GetObject("CHE"), //4
            (Image)Properties.Resources.ResourceManager.GetObject("PYA"), //5
            (Image)Properties.Resources.ResourceManager.GetObject("SHE"), //6
            (Image)Properties.Resources.ResourceManager.GetObject("SEM"), //7
            (Image)Properties.Resources.ResourceManager.GetObject("VOS"), //8
            (Image)Properties.Resources.ResourceManager.GetObject("DEV"), //9
            (Image)Properties.Resources.ResourceManager.GetObject("low"), //10
            (Image)Properties.Resources.ResourceManager.GetObject("bottom"), //11
            (Image)Properties.Resources.ResourceManager.GetObject("learning"), //12
            (Image)Properties.Resources.ResourceManager.GetObject("learnt"), //13
            (Image)Properties.Resources.ResourceManager.GetObject("silence"), //14
        };
        string masReadFile, masPreFile1, masPreFile2, masPreFile3, masPreFile4;
        int[] masPixelValues = new int[144];
        int[] masPixelValuesF = new int[144];


        public Form1()
        {
            InitializeComponent();
            //===============================================================================//
            Bitmap bitmap = new Bitmap(picDistinguish.Width, picDistinguish.Height);
            picDistinguish.Image = bitmap;
            gr = Graphics.FromImage(bitmap);
            //-------------------------------------------------------------------------------//
            Bitmap bitmapF = new Bitmap(picDistinguishF.Width, picDistinguishF.Height);
            picDistinguishF.Image = bitmapF;
            grF = Graphics.FromImage(bitmapF);
            //===============================================================================//
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Заливка PictureBox белым
            gr.FillRectangle(Brushes.White, 0, 0, picDistinguish.Width, picDistinguish.Height);
            grF.FillRectangle(Brushes.White, 0, 0, picDistinguishF.Width, picDistinguishF.Height);

            //Работа с ToolTip -------------------------------------------------------------------------------
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 3000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.picPixF, "Сжатое изображение");
            toolTip1.SetToolTip(this.pnlColorsF, "Пикселизированное изображение");
            toolTip1.SetToolTip(this.pnlBW, "Считанные значения цвета");
            toolTip1.SetToolTip(this.picNumHigh, "На что похоже изображение");
            toolTip1.SetToolTip(this.rtxtPixColorF, "Результат сравнения изображения с каждой цифрой");
            toolTip1.SetToolTip(this.btnFalseResult, "Нажать, если программа видит не ту цифру");
            toolTip1.SetToolTip(this.picRead, "Считанное изображение");
            toolTip1.SetToolTip(this.picPix, "Сжатое изображение");
            toolTip1.SetToolTip(this.pnlColors, "Пикселизированное изображение");
            toolTip1.SetToolTip(this.txtPixColor, "Значения цвета отдельного пикселя");
            toolTip1.SetToolTip(this.txtNumbers, "Массив считанных значений");
            toolTip1.SetToolTip(this.lblInfo, "Информация о созданном файле");
            //------------------------------------------------------------------------------------------------
        }


        //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        NeuralNet net;
        float[] input;
        //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=


        //Вкладка с добавлением строк в файл
        private void picDistinguish_MouseDown(object sender, MouseEventArgs e)
        {
            //Рисование Кругов
            currentX = e.X;
            currentY = e.Y;
            pastX = e.X;
            pastY = e.Y;

            Pen penCircles = new Pen(br, 9);

            gr.DrawEllipse(penCircles, currentX, currentY, 7, 7);
            picDistinguish.Invalidate();
            gr.FillEllipse(Brushes.Black, pastX, pastY, 7, 7);
            picDistinguish.Invalidate();
        }

        private void picDistinguish_MouseMove(object sender, MouseEventArgs e)
        {
            // Рисование линий
            if (e.Button == MouseButtons.Left)
            {
                Pen penCircles = new Pen(br, 22);
                Pen penLines = new Pen(br, 26);

                currentX = e.X;
                currentY = e.Y;

                gr.DrawLine(penLines, pastX, pastY, currentX, currentY);
                picDistinguish.Invalidate();
                gr.DrawEllipse(penCircles, currentX, currentY, 7, 7);
                picDistinguish.Invalidate();
                gr.FillEllipse(Brushes.Black, pastX, pastY, 7, 7);
                picDistinguish.Invalidate();

                pastX = currentX;
                pastY = currentY;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            picPix.Image = null;
            picDistinguish.Image = null;
            picRead.Image = null;
            pnlColors.Controls.Clear();
            txtNumbers.Text = "";
            txtPixColor.Text = "";

            Bitmap bitmap = new Bitmap(picDistinguish.Width, picDistinguish.Height);
            picDistinguish.Image = bitmap;
            gr = Graphics.FromImage(bitmap);

            foreach (RadioButton rb in grRadioButtons.Controls)
            {
                rb.Checked = false;
            }

            gr.FillRectangle(Brushes.White, 0, 0, picDistinguish.Width, picDistinguish.Height); //Нарисовать белый прямоугольник для очистки графики
            picDistinguish.Invalidate(); //Обновить

            btnToTxt.Enabled = false;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //string pixelValues = "";

            PictureDistinguish(picDistinguish, picRead, picPix, pnlColors, txtNumbers, masPixelValues);

            picDistinguish.Image.Save("save_pic.jpg", ImageFormat.Jpeg); //Сохранить графику в .jpg

            foreach (PictureBox pic in pnlColors.Controls)
            {
                pic.MouseDown += Pic_MouseDown;
            }

            btnToTxt.Enabled = true;
        }

        private void btnToTxt_Click(object sender, EventArgs e)
        {
            int r0 = 0, r1 = 0, r2 = 0, r3 = 0, r4 = 0, r5 = 0, r6 = 0, r7 = 0, r8 = 0, r9 = 0;
            string currentLine = "";
            for (int i = 0; i < 144; i++)
            {
                currentLine += masPixelValues[i].ToString() + " ";
            }

            if (rb0.Checked) r0 = 1;
            else if (rb1.Checked) r1 = 1;
            else if (rb2.Checked) r2 = 1;
            else if (rb3.Checked) r3 = 1;
            else if (rb4.Checked) r4 = 1;
            else if (rb5.Checked) r5 = 1;
            else if (rb6.Checked) r6 = 1;
            else if (rb7.Checked) r7 = 1;
            else if (rb8.Checked) r8 = 1;
            else if (rb9.Checked) r9 = 1;
            else MessageBox.Show("Выберите, какая цифра была считана", "ВНИМАНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (r0 == 1 || r1 == 1 || r2 == 1 || r3 == 1 || r4 == 1 || r5 == 1 || r6 == 1 || r7 == 1 || r8 == 1 || r9 == 1)
            {
                string rbValues = r0.ToString() + " " + r1.ToString() + " " + r2.ToString() + " " + r3.ToString() + " " + r4.ToString() + " " + r5.ToString() + " " + r6.ToString() + " " + r7.ToString() + " " + r8.ToString() + " " + r9.ToString() + " ";
                File.AppendAllText("testFile.txt", currentLine + " " + rbValues + "\r\n");
            }

            btnToTxt.Enabled = false;
        }

        private void picRead_DoubleClick(object sender, EventArgs e)
        {
            if (picRead.Tag.ToString() == "ooo")
            {
                txtNumbers.Text = txtNumbers.Text.Replace("0", "░");
                txtNumbers.Text = txtNumbers.Text.Replace("1", "█");
                picRead.Tag = "ppp";
            }
            else
            {
                txtNumbers.Text = txtNumbers.Text.Replace("░", "0");
                txtNumbers.Text = txtNumbers.Text.Replace("█", "1");
                picRead.Tag = "ooo";
            }
        }

        //Вкладка для работы с файлами 
        private void btnToData_Click(object sender, EventArgs e)
        {
            txtDataIndicate.Text = "Подождите...";
            int mLength = 0, stroki;
            string prev, finPrev;

            //Убрать из файла все лишние символы ~~~~~~~~~~~~~~~~
            masPreFile1 = File.ReadAllText("testFile.txt");
            masPreFile2 = masPreFile1.Replace(" ", "");
            masPreFile3 = masPreFile2.Replace("-", "");
            masPreFile4 = masPreFile3.Replace("\r\n", "");
            masReadFile = masPreFile4.Replace(",", "");
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            // Проверка получившегося файла (Проверка файла на правильность составления »»»»»»»»»»
            //MessageBox.Show(masPreFile3); //Работает с длиной файла менее 64000 знаков
            //using (StreamWriter wFile = new StreamWriter("checkData.data"))
            //{
            //    wFile.Dispose(); 
            //}
            //using (StreamWriter wFile = new StreamWriter("checkData.data"))
            //{
            //    wFile.WriteLine(masReadFile);
            //}
            //»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»


            //Проверка количества введённых строк и нейронов
            //========================================================================================
            mLength = masReadFile.Length;
            stroki = mLength / 154;                  /* Количество строк потребуется при динамическом создани файла с данными*/
            lblInfo.Text = "Число строк: " + stroki + "\r\n" + "Число нейронов на вход: 144 \r\n" + "Число нейронов на выход: 10 \r\n \r\n" + "Длина файла: " + mLength.ToString();
            //========================================================================================


            // Формирование DATA файла ______________________________________________________________
            prev = File.ReadAllText("testFile.txt");
            using (StreamWriter wFile = new StreamWriter("testData.data"))
            {
                wFile.Dispose();
            }
            using (StreamWriter wFile = new StreamWriter("testData.data"))
            {
                string s = stroki + " " + "144" + " " + "10" + " " + "\r\n" + prev;
                wFile.WriteLine(s);
            }
            //________________________________________________________________________________________

            //Визуальное отображение
            picDataIndicate.Image = masImages[12];
            txtDataIndicate.Text = "Обучите" + "\r\n" + "программу";

            btnToData.BackColor = Color.White;
            btnLearn.BackColor = Color.SkyBlue;
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            txtDataIndicate.Text = "Подождите...";

            MessageBox.Show("Это действие может занять до 40 секунд", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Stopwatch countLearnTime = new Stopwatch();
            countLearnTime.Start();

            uint num_input = 144; // Количество нейронов на вход
            uint num_out = 10; // Количество нейронов на результат
            uint num_layer = 3;
            uint num_hidden = 145; //
            float num_error = 0.001f; //Величина ошибки
            uint max_epochs = 50000; //Максимум итераций
            uint epochs_between = 1000;

            net = new NeuralNet(NetworkType.LAYER, num_layer, num_input, num_hidden, num_out);

            using (net)
            {
                net.ActivationFunctionHidden = ActivationFunction.SIGMOID_SYMMETRIC;
                net.ActivationFunctionOutput = ActivationFunction.SIGMOID_SYMMETRIC;

                net.TrainOnFile("testData.data", max_epochs, epochs_between, num_error); //Файл,на котором программа учится
                net.Save("testData_float.net");
            }

            countLearnTime.Stop();

            //Визуальное отображение
            picDataIndicate.Image = masImages[13];
            double secondsTaken = countLearnTime.ElapsedMilliseconds / 1000;
            txtDataIndicate.Text = "Программа готова" + "\r\n" + "распознавать (" + Math.Round(secondsTaken, 2).ToString() + " сек.)";
            btnLearn.BackColor = Color.White;
            System.Media.SystemSounds.Exclamation.Play();
        }
    
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            picDataIndicate.Image = masImages[14];
            txtDataIndicate.Text = "Создайте DATA" + "\r\n" + "файл";

            btnToData.BackColor = Color.SkyBlue;
            btnLearn.BackColor = Color.White;
        }


        //Вкладка для основной работы
        private void picDistinguishF_MouseDown(object sender, MouseEventArgs e)
        {
            currentX = e.X;
            currentY = e.Y;
            pastX = e.X;
            pastY = e.Y;

            Pen penCircles = new Pen(br, 9);

            grF.DrawEllipse(penCircles, currentX, currentY, 7, 7);
            picDistinguishF.Invalidate();
            grF.FillEllipse(Brushes.Black, pastX, pastY, 7, 7);
            picDistinguishF.Invalidate();
        }

        private void picDistinguishF_MouseMove(object sender, MouseEventArgs e)
        {
            // Рисование линий
            if (e.Button == MouseButtons.Left)
            {
                Pen penCircles = new Pen(br, 22);
                Pen penLines = new Pen(br, 26);

                currentX = e.X;
                currentY = e.Y;

                grF.DrawLine(penLines, pastX, pastY, currentX, currentY);
                picDistinguishF.Invalidate();
                grF.DrawEllipse(penCircles, currentX, currentY, 7, 7);
                picDistinguishF.Invalidate();
                grF.FillEllipse(Brushes.Black, pastX, pastY, 7, 7);
                picDistinguishF.Invalidate();

                pastX = currentX;
                pastY = currentY;
            }
        }

        private void btnClearF_Click(object sender, EventArgs e)
        {
            grF.FillRectangle(Brushes.White, 0, 0, picDistinguishF.Width, picDistinguishF.Height); //Нарисовать белый прямоугольник для очистки графики
            picDistinguishF.Invalidate(); //Обновить

            picPixF.Image = null;
            picReadF.Image = null;
            pnlColorsF.Controls.Clear();
            picNumHigh.Image = null;
            pnlBW.Controls.Clear();
            rtxtPixColorF.Text = "";

        }

        private void btnReadF_Click(object sender, EventArgs e)
        {
            PictureDistinguish(picDistinguishF, picReadF, picPixF, pnlColorsF, txtNumbersF, masPixelValuesF);
            pnlBW.Controls.Clear();
            rtxtPixColorF.Text = "";
            picNumHigh.Image = null;

            int n = 0;
            //Заполнение панели параметрами цвета пикселей (ч/б)
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Color pixel;
                    if (masPixelValuesF[n] == 0) pixel = Color.White;
                    else pixel = Color.Black;

                    PictureBox picCreateF = new PictureBox(); //Создание кнопки-пикселя для проверки цвета
                    picCreateF.BackColor = pixel;
                    picCreateF.Size = new Size(20, 20);
                    picCreateF.Location = new Point(j * 20, i * 20);

                    pnlBW.Controls.Add(picCreateF); //Вывод параметров цвета выбранного пикселя в текстовое поле
                    n++;
                }
                
            }

            using (TrainingData data = new TrainingData())
            {
                if (File.Exists("testData_float.net")) // using System.IO;
                {
                    //---------------------------------------------------------------------------------
                    //Получение calc_out
                    rtxtPixColorF.AppendText("Connection Exists" + "\r\n");
                    net = new NeuralNet("testData_float.net");

                    input = new float[144];
                    for(int i = 0; i < 144; i++)
                    {
                        input[i] = masPixelValuesF[i];
                    }

                    float[] calc_out = net.Run(input);
                    //---------------------------------------------------------------------------------

                    //###############################################################################################################
                    float[] masShuffle = new float[10];  //Массив, из которого отбираются максимальные значения (Нужен исключительно для перебора значений)
                    float[] masSort = new float[10];  // Массив значений calc_out по убыванию
                    Color[] sortColors = new Color[4] {Color.FromArgb(0, 139, 0), Color.FromArgb(238, 238, 0), Color.FromArgb(238, 180, 34), Color.FromArgb(139, 26, 26)};

                    //Заполнение временного массива
                    for (int i = 0; i < 10; i++)
                    {
                        masShuffle[i] = (float)calc_out[i];
                    }

                    //Заполнение отсортированного массива 
                    for (int i = 0; i < 10; i++)
                    {
                        float maxOut = masShuffle.Max();
                        int indOfMax = masShuffle.ToList().IndexOf(maxOut);  //Индекс максимального значения массива

                        masSort[i] = maxOut;
                        masShuffle[indOfMax] = -2;
                    }
                    //###############################################################################################################

                    for (int i = 0; i < 10; i++) //Выделеть цветом три наилучших результата сравнения и один наихудший
                    {
                        rtxtPixColorF.AppendText(i + ": " + calc_out[i] + "\r\n");
                        rtxtPixColorF.SelectionStart = rtxtPixColorF.TextLength - (2 + (calc_out[i]).ToString().Length);
                        rtxtPixColorF.SelectionLength = rtxtPixColorF.TextLength;

                        if ((float)calc_out[i] == masSort[0]) 
                        {
                            rtxtPixColorF.SelectionColor = sortColors[0]; 
                            rtxtPixColorF.SelectionFont = new Font(rtxtPixColorF.Font.FontFamily, this.Font.Size, FontStyle.Bold); 
                        }
                        else if (calc_out[i] == masSort[1])
                        {
                            rtxtPixColorF.SelectionColor = sortColors[1];
                            rtxtPixColorF.SelectionFont = new Font(rtxtPixColorF.Font.FontFamily, this.Font.Size, FontStyle.Bold);
                        }
                        else if (calc_out[i] == masSort[2])
                        {
                            rtxtPixColorF.SelectionColor = sortColors[2];
                            rtxtPixColorF.SelectionFont = new Font(rtxtPixColorF.Font.FontFamily, this.Font.Size, FontStyle.Bold);
                        }
                        else if (calc_out[i] == masSort[9])
                        {
                            rtxtPixColorF.SelectionColor = sortColors[3];
                            rtxtPixColorF.SelectionFont = new Font(rtxtPixColorF.Font.FontFamily, this.Font.Size, FontStyle.Bold);
                        }
                    }
                    rtxtPixColorF.AppendText("\r\n");

                    if(masSort[0] > 0.25)
                    {
                        picNumHigh.Image = masImages[calc_out.ToList().IndexOf(masSort[0])]; 
                    }
                    else if (masSort[0] > 0.09)
                    {
                        picNumHigh.Image = masImages[10];
                    }
                    else
                    {
                        picNumHigh.Image = masImages[11];
                    }

                    //Введения string переменной для упрощения процесса выделения текста
                    string[] masBeau = new string[4] 
                    {
                        ("\r\n" + "First: " + masSort[0] + "  —  (" + calc_out.ToList().IndexOf(masSort[0]).ToString() + ")"),
                        ("\r\n" + "Second: " + masSort[1] + "  —  (" + calc_out.ToList().IndexOf(masSort[1]).ToString() + ")"),
                        ("\r\n" + "Third: " + masSort[2] + "  —  (" + calc_out.ToList().IndexOf(masSort[2]).ToString() + ")"),
                        ("\r\n" + "\r\n" + "Last: " + masSort[9] + "  —  (" + calc_out.ToList().IndexOf(masSort[9]).ToString() + ")")
                    };

                    //Дублировать на отдельных строчках и выделить лучшие результаты
                    for(int i = 0; i < 4; i++) 
                    {
                        rtxtPixColorF.AppendText(masBeau[i]);  

                        rtxtPixColorF.SelectionStart = rtxtPixColorF.TextLength - (masBeau[i].Length-2);
                        rtxtPixColorF.SelectionLength = rtxtPixColorF.TextLength; 

                        rtxtPixColorF.SelectionColor = sortColors[i];
                        rtxtPixColorF.SelectionFont = new Font(rtxtPixColorF.Font.FontFamily, this.Font.Size, FontStyle.Bold);

                        rtxtPixColorF.SelectionLength = 0;
                    }

                    //Если результат считывания неудовлетворяющий
                    if((masSort[0] - masSort[1]) < 0.2)
                    {
                        MessageBox.Show("Разница между наивысшими результатами слишком мала: " + Math.Abs(masSort[0] - masSort[1]), "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (masSort[0] < 0.6)
                    {
                        MessageBox.Show("Максимальный результат слишком мал: " + masSort[0], "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void btnFalseResult_Click(object sender, EventArgs e)
        {
            picDistinguish.Image = picDistinguishF.Image; 
            
            tabControl.SelectTab("tabPageAdd");
        }


        //Методы для создаваемых PictureBox
        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pic = sender as PictureBox;

            //Параметры цвета пикселя

            txtPixColor.Text = "";
            txtPixColor.Text += "R: " + pic.BackColor.R + "\r\n";
            txtPixColor.Text += "G: " + pic.BackColor.G + "\r\n";
            txtPixColor.Text += "B: " + pic.BackColor.B + "\r\n";
            txtPixColor.Text += "ARGB: " + pic.BackColor.ToArgb().ToString() + "\r\n";
            txtPixColor.Text += "Known: " + pic.BackColor.ToKnownColor().ToString() + "\r\n";
            if (Convert.ToInt32(pic.BackColor.R) < 150) txtPixColor.Text += "BLACK";
            else txtPixColor.Text += "WHITE";

            pic.BorderStyle = BorderStyle.FixedSingle;
        }


        //Метод распознавания (получение массива значений с картинки и сопутствующие визуальные отображения)
        private void PictureDistinguish(PictureBox pic1, PictureBox pic2, PictureBox pic3, Panel pnl1, TextBox txt1, int[] mas1)
        {
            //1) PictureBox, с которого считывается изображени
            //2) PictureBox, в который оно передаётся
            //3) PictureBox, где происходит сжатие
            //4) Panel, где хранятся ихображения с цветом каждого пикселя
            //5) String, текст со значениями цвета в ч/б всех пикселей

            pic1.Image.Save("save_pic.jpg", ImageFormat.Jpeg); //Сохранить графику в .jpg
            string picColorsMas = "";
            txt1.Text = "";

            //Необязательный шаг (Проверка преобразования графики в изображение)
            pic2.Image = pic1.Image; //Передать графику на PictureBox 2
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.Invalidate();
            
            Bitmap getPic = new Bitmap(pic1.Image);  //Сжать картинку до размера 12х12 и сохранить в PictureBox 3
            Bitmap setPic = new Bitmap(getPic, 12, 12);
            pic3.Image = setPic;
            pic3.Image.Save("save_pic_pixelise.jpg", ImageFormat.Jpeg); //Сохранить пикселизированное изображение в .jpg

            Bitmap bit = new Bitmap(pic1.Image, 12, 12);   //Проверить цвета наглядно
            pnl1.Controls.Clear();

            string[] masPix = new string[144]; // Массив цветов картинки
            int count = 0;
            //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=//
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    int picColor;
                    Color pixel = bit.GetPixel(j, i); //Считать цвет пикселя

                    if (Convert.ToInt32(pixel.R) < 150) picColor = 1;
                    else picColor = 0;
                    txt1.Text += picColor.ToString() + "  ";
                    picColorsMas += picColor.ToString() + " ";

                    mas1[count] = picColor;
                    count++;

                    PictureBox picCreate = new PictureBox(); //Создание кнопки-пикселя для проверки цвета
                    picCreate.BackColor = pixel;
                    picCreate.Size = new Size(20, 20);
                    picCreate.Location = new Point(j * 20, i * 20);

                    pnl1.Controls.Add(picCreate); //Вывод параметров цвета выбранного пикселя в текстовое поле
                }
                txt1.Text += "\r\n";
            } 
            //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=//
        }
    }
}


namespace prDistinguishNumbers
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageFin = new System.Windows.Forms.TabPage();
            this.rtxtPixColorF = new System.Windows.Forms.RichTextBox();
            this.picNumHigh = new System.Windows.Forms.PictureBox();
            this.btnFalseResult = new System.Windows.Forms.Button();
            this.txtNumbersF = new System.Windows.Forms.TextBox();
            this.pnlColorsF = new System.Windows.Forms.Panel();
            this.pnlBW = new System.Windows.Forms.Panel();
            this.btnReadF = new System.Windows.Forms.Button();
            this.btnClearF = new System.Windows.Forms.Button();
            this.picReadF = new System.Windows.Forms.PictureBox();
            this.picPixF = new System.Windows.Forms.PictureBox();
            this.picDistinguishF = new System.Windows.Forms.PictureBox();
            this.tabPageBetween = new System.Windows.Forms.TabPage();
            this.txtDataIndicate = new System.Windows.Forms.TextBox();
            this.picDataIndicate = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnToData = new System.Windows.Forms.Button();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.btnToTxt = new System.Windows.Forms.Button();
            this.grRadioButtons = new System.Windows.Forms.GroupBox();
            this.rb9 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb0 = new System.Windows.Forms.RadioButton();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.txtPixColor = new System.Windows.Forms.TextBox();
            this.pnlColors = new System.Windows.Forms.Panel();
            this.picPix = new System.Windows.Forms.PictureBox();
            this.picRead = new System.Windows.Forms.PictureBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.picDistinguish = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.tabPageFin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNumHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReadF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPixF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDistinguishF)).BeginInit();
            this.tabPageBetween.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDataIndicate)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            this.grRadioButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDistinguish)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageFin);
            this.tabControl.Controls.Add(this.tabPageBetween);
            this.tabControl.Controls.Add(this.tabPageAdd);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1384, 663);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageFin
            // 
            this.tabPageFin.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPageFin.Controls.Add(this.rtxtPixColorF);
            this.tabPageFin.Controls.Add(this.picNumHigh);
            this.tabPageFin.Controls.Add(this.btnFalseResult);
            this.tabPageFin.Controls.Add(this.txtNumbersF);
            this.tabPageFin.Controls.Add(this.pnlColorsF);
            this.tabPageFin.Controls.Add(this.pnlBW);
            this.tabPageFin.Controls.Add(this.btnReadF);
            this.tabPageFin.Controls.Add(this.btnClearF);
            this.tabPageFin.Controls.Add(this.picReadF);
            this.tabPageFin.Controls.Add(this.picPixF);
            this.tabPageFin.Controls.Add(this.picDistinguishF);
            this.tabPageFin.Location = new System.Drawing.Point(4, 34);
            this.tabPageFin.Name = "tabPageFin";
            this.tabPageFin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFin.Size = new System.Drawing.Size(1376, 625);
            this.tabPageFin.TabIndex = 2;
            this.tabPageFin.Text = "Распознать";
            // 
            // rtxtPixColorF
            // 
            this.rtxtPixColorF.BackColor = System.Drawing.Color.White;
            this.rtxtPixColorF.Location = new System.Drawing.Point(1050, 54);
            this.rtxtPixColorF.Name = "rtxtPixColorF";
            this.rtxtPixColorF.ReadOnly = true;
            this.rtxtPixColorF.Size = new System.Drawing.Size(303, 440);
            this.rtxtPixColorF.TabIndex = 7;
            this.rtxtPixColorF.Text = "";
            // 
            // picNumHigh
            // 
            this.picNumHigh.BackColor = System.Drawing.Color.White;
            this.picNumHigh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNumHigh.Image = global::prDistinguishNumbers.Properties.Resources.silence;
            this.picNumHigh.Location = new System.Drawing.Point(781, 320);
            this.picNumHigh.Name = "picNumHigh";
            this.picNumHigh.Size = new System.Drawing.Size(240, 240);
            this.picNumHigh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNumHigh.TabIndex = 10;
            this.picNumHigh.TabStop = false;
            // 
            // btnFalseResult
            // 
            this.btnFalseResult.BackColor = System.Drawing.Color.White;
            this.btnFalseResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFalseResult.Image = global::prDistinguishNumbers.Properties.Resources.err;
            this.btnFalseResult.Location = new System.Drawing.Point(1050, 500);
            this.btnFalseResult.Name = "btnFalseResult";
            this.btnFalseResult.Size = new System.Drawing.Size(303, 60);
            this.btnFalseResult.TabIndex = 9;
            this.btnFalseResult.Text = "Результат не соответствует картинке";
            this.btnFalseResult.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFalseResult.UseVisualStyleBackColor = false;
            this.btnFalseResult.Click += new System.EventHandler(this.btnFalseResult_Click);
            // 
            // txtNumbersF
            // 
            this.txtNumbersF.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNumbersF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumbersF.Enabled = false;
            this.txtNumbersF.ForeColor = System.Drawing.Color.Transparent;
            this.txtNumbersF.Location = new System.Drawing.Point(300, 510);
            this.txtNumbersF.Name = "txtNumbersF";
            this.txtNumbersF.ReadOnly = true;
            this.txtNumbersF.Size = new System.Drawing.Size(100, 23);
            this.txtNumbersF.TabIndex = 8;
            this.txtNumbersF.Visible = false;
            // 
            // pnlColorsF
            // 
            this.pnlColorsF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlColorsF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColorsF.Location = new System.Drawing.Point(781, 54);
            this.pnlColorsF.Name = "pnlColorsF";
            this.pnlColorsF.Size = new System.Drawing.Size(240, 240);
            this.pnlColorsF.TabIndex = 4;
            // 
            // pnlBW
            // 
            this.pnlBW.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlBW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBW.Location = new System.Drawing.Point(513, 320);
            this.pnlBW.Name = "pnlBW";
            this.pnlBW.Size = new System.Drawing.Size(240, 240);
            this.pnlBW.TabIndex = 3;
            // 
            // btnReadF
            // 
            this.btnReadF.BackColor = System.Drawing.Color.Cyan;
            this.btnReadF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReadF.Image = global::prDistinguishNumbers.Properties.Resources.read;
            this.btnReadF.Location = new System.Drawing.Point(26, 537);
            this.btnReadF.Name = "btnReadF";
            this.btnReadF.Size = new System.Drawing.Size(282, 60);
            this.btnReadF.TabIndex = 6;
            this.btnReadF.Text = "Распознать";
            this.btnReadF.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReadF.UseVisualStyleBackColor = false;
            this.btnReadF.Click += new System.EventHandler(this.btnReadF_Click);
            // 
            // btnClearF
            // 
            this.btnClearF.BackColor = System.Drawing.Color.White;
            this.btnClearF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearF.Image = global::prDistinguishNumbers.Properties.Resources.erase;
            this.btnClearF.Location = new System.Drawing.Point(314, 537);
            this.btnClearF.Name = "btnClearF";
            this.btnClearF.Size = new System.Drawing.Size(162, 60);
            this.btnClearF.TabIndex = 5;
            this.btnClearF.Text = "Очистить";
            this.btnClearF.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClearF.UseVisualStyleBackColor = false;
            this.btnClearF.Click += new System.EventHandler(this.btnClearF_Click);
            // 
            // picReadF
            // 
            this.picReadF.Enabled = false;
            this.picReadF.Location = new System.Drawing.Point(406, 510);
            this.picReadF.Name = "picReadF";
            this.picReadF.Size = new System.Drawing.Size(100, 50);
            this.picReadF.TabIndex = 2;
            this.picReadF.TabStop = false;
            this.picReadF.Visible = false;
            // 
            // picPixF
            // 
            this.picPixF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picPixF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPixF.Location = new System.Drawing.Point(513, 54);
            this.picPixF.Name = "picPixF";
            this.picPixF.Size = new System.Drawing.Size(240, 240);
            this.picPixF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPixF.TabIndex = 1;
            this.picPixF.TabStop = false;
            // 
            // picDistinguishF
            // 
            this.picDistinguishF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picDistinguishF.Location = new System.Drawing.Point(26, 54);
            this.picDistinguishF.Name = "picDistinguishF";
            this.picDistinguishF.Size = new System.Drawing.Size(450, 450);
            this.picDistinguishF.TabIndex = 0;
            this.picDistinguishF.TabStop = false;
            this.picDistinguishF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDistinguishF_MouseDown);
            this.picDistinguishF.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDistinguishF_MouseMove);
            // 
            // tabPageBetween
            // 
            this.tabPageBetween.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPageBetween.Controls.Add(this.txtDataIndicate);
            this.tabPageBetween.Controls.Add(this.picDataIndicate);
            this.tabPageBetween.Controls.Add(this.lblInfo);
            this.tabPageBetween.Controls.Add(this.btnLearn);
            this.tabPageBetween.Controls.Add(this.btnToData);
            this.tabPageBetween.Location = new System.Drawing.Point(4, 34);
            this.tabPageBetween.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageBetween.Name = "tabPageBetween";
            this.tabPageBetween.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageBetween.Size = new System.Drawing.Size(1376, 625);
            this.tabPageBetween.TabIndex = 1;
            this.tabPageBetween.Text = "Промежуточные шаги";
            // 
            // txtDataIndicate
            // 
            this.txtDataIndicate.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDataIndicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDataIndicate.Location = new System.Drawing.Point(830, 363);
            this.txtDataIndicate.Multiline = true;
            this.txtDataIndicate.Name = "txtDataIndicate";
            this.txtDataIndicate.ReadOnly = true;
            this.txtDataIndicate.Size = new System.Drawing.Size(240, 66);
            this.txtDataIndicate.TabIndex = 4;
            this.txtDataIndicate.Text = "Создайте DATA файл";
            this.txtDataIndicate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picDataIndicate
            // 
            this.picDataIndicate.BackgroundImage = global::prDistinguishNumbers.Properties.Resources.silence;
            this.picDataIndicate.Location = new System.Drawing.Point(830, 116);
            this.picDataIndicate.Name = "picDataIndicate";
            this.picDataIndicate.Size = new System.Drawing.Size(240, 240);
            this.picDataIndicate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDataIndicate.TabIndex = 3;
            this.picDataIndicate.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(464, 116);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(37, 25);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = ". . .";
            // 
            // btnLearn
            // 
            this.btnLearn.BackColor = System.Drawing.Color.White;
            this.btnLearn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLearn.Location = new System.Drawing.Point(124, 260);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(225, 75);
            this.btnLearn.TabIndex = 1;
            this.btnLearn.Text = "Обучить программу";
            this.btnLearn.UseVisualStyleBackColor = false;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // btnToData
            // 
            this.btnToData.BackColor = System.Drawing.Color.SkyBlue;
            this.btnToData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToData.Location = new System.Drawing.Point(124, 116);
            this.btnToData.Name = "btnToData";
            this.btnToData.Size = new System.Drawing.Size(225, 75);
            this.btnToData.TabIndex = 0;
            this.btnToData.Text = "Создать DATA файл";
            this.btnToData.UseVisualStyleBackColor = false;
            this.btnToData.Click += new System.EventHandler(this.btnToData_Click);
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPageAdd.Controls.Add(this.btnToTxt);
            this.tabPageAdd.Controls.Add(this.grRadioButtons);
            this.tabPageAdd.Controls.Add(this.txtNumbers);
            this.tabPageAdd.Controls.Add(this.txtPixColor);
            this.tabPageAdd.Controls.Add(this.pnlColors);
            this.tabPageAdd.Controls.Add(this.picPix);
            this.tabPageAdd.Controls.Add(this.picRead);
            this.tabPageAdd.Controls.Add(this.btnRead);
            this.tabPageAdd.Controls.Add(this.btnClear);
            this.tabPageAdd.Controls.Add(this.picDistinguish);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 34);
            this.tabPageAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAdd.Size = new System.Drawing.Size(1376, 625);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Tag = "0";
            this.tabPageAdd.Text = "Добавить картинку";
            // 
            // btnToTxt
            // 
            this.btnToTxt.BackColor = System.Drawing.Color.White;
            this.btnToTxt.Enabled = false;
            this.btnToTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToTxt.Image = global::prDistinguishNumbers.Properties.Resources.add;
            this.btnToTxt.Location = new System.Drawing.Point(1085, 541);
            this.btnToTxt.Name = "btnToTxt";
            this.btnToTxt.Size = new System.Drawing.Size(240, 60);
            this.btnToTxt.TabIndex = 9;
            this.btnToTxt.Text = "Добавить в файл";
            this.btnToTxt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnToTxt.UseVisualStyleBackColor = false;
            this.btnToTxt.Click += new System.EventHandler(this.btnToTxt_Click);
            // 
            // grRadioButtons
            // 
            this.grRadioButtons.BackColor = System.Drawing.Color.OldLace;
            this.grRadioButtons.Controls.Add(this.rb9);
            this.grRadioButtons.Controls.Add(this.rb8);
            this.grRadioButtons.Controls.Add(this.rb7);
            this.grRadioButtons.Controls.Add(this.rb6);
            this.grRadioButtons.Controls.Add(this.rb5);
            this.grRadioButtons.Controls.Add(this.rb4);
            this.grRadioButtons.Controls.Add(this.rb3);
            this.grRadioButtons.Controls.Add(this.rb2);
            this.grRadioButtons.Controls.Add(this.rb1);
            this.grRadioButtons.Controls.Add(this.rb0);
            this.grRadioButtons.Location = new System.Drawing.Point(513, 526);
            this.grRadioButtons.Name = "grRadioButtons";
            this.grRadioButtons.Size = new System.Drawing.Size(554, 95);
            this.grRadioButtons.TabIndex = 8;
            this.grRadioButtons.TabStop = false;
            this.grRadioButtons.Text = "Какая цифра нарисована?";
            // 
            // rb9
            // 
            this.rb9.AutoSize = true;
            this.rb9.Location = new System.Drawing.Point(474, 40);
            this.rb9.Name = "rb9";
            this.rb9.Size = new System.Drawing.Size(44, 29);
            this.rb9.TabIndex = 9;
            this.rb9.Text = "9";
            this.rb9.UseVisualStyleBackColor = true;
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Location = new System.Drawing.Point(424, 40);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(44, 29);
            this.rb8.TabIndex = 8;
            this.rb8.Text = "8";
            this.rb8.UseVisualStyleBackColor = true;
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.Location = new System.Drawing.Point(374, 40);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(44, 29);
            this.rb7.TabIndex = 7;
            this.rb7.Text = "7";
            this.rb7.UseVisualStyleBackColor = true;
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Location = new System.Drawing.Point(324, 40);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(44, 29);
            this.rb6.TabIndex = 6;
            this.rb6.Text = "6";
            this.rb6.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(274, 40);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(44, 29);
            this.rb5.TabIndex = 5;
            this.rb5.Text = "5";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(224, 40);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(44, 29);
            this.rb4.TabIndex = 4;
            this.rb4.Text = "4";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(174, 40);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(44, 29);
            this.rb3.TabIndex = 3;
            this.rb3.Text = "3";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(124, 40);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(44, 29);
            this.rb2.TabIndex = 2;
            this.rb2.Text = "2";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(74, 40);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(44, 29);
            this.rb1.TabIndex = 1;
            this.rb1.Text = "1";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb0
            // 
            this.rb0.AutoSize = true;
            this.rb0.Location = new System.Drawing.Point(24, 40);
            this.rb0.Name = "rb0";
            this.rb0.Size = new System.Drawing.Size(44, 29);
            this.rb0.TabIndex = 0;
            this.rb0.Text = "0";
            this.rb0.UseVisualStyleBackColor = true;
            // 
            // txtNumbers
            // 
            this.txtNumbers.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNumbers.Location = new System.Drawing.Point(932, 310);
            this.txtNumbers.Multiline = true;
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(393, 194);
            this.txtNumbers.TabIndex = 7;
            // 
            // txtPixColor
            // 
            this.txtPixColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPixColor.Location = new System.Drawing.Point(513, 310);
            this.txtPixColor.Multiline = true;
            this.txtPixColor.Name = "txtPixColor";
            this.txtPixColor.Size = new System.Drawing.Size(393, 194);
            this.txtPixColor.TabIndex = 0;
            // 
            // pnlColors
            // 
            this.pnlColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColors.Location = new System.Drawing.Point(1085, 54);
            this.pnlColors.Name = "pnlColors";
            this.pnlColors.Size = new System.Drawing.Size(240, 240);
            this.pnlColors.TabIndex = 6;
            // 
            // picPix
            // 
            this.picPix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picPix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPix.Location = new System.Drawing.Point(800, 54);
            this.picPix.Name = "picPix";
            this.picPix.Size = new System.Drawing.Size(240, 240);
            this.picPix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPix.TabIndex = 5;
            this.picPix.TabStop = false;
            // 
            // picRead
            // 
            this.picRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picRead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRead.Location = new System.Drawing.Point(513, 54);
            this.picRead.Name = "picRead";
            this.picRead.Size = new System.Drawing.Size(240, 240);
            this.picRead.TabIndex = 3;
            this.picRead.TabStop = false;
            this.picRead.Tag = "ooo";
            this.picRead.DoubleClick += new System.EventHandler(this.picRead_DoubleClick);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.Cyan;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRead.Image = global::prDistinguishNumbers.Properties.Resources.read;
            this.btnRead.Location = new System.Drawing.Point(25, 537);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(282, 60);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Распознать";
            this.btnRead.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Image = global::prDistinguishNumbers.Properties.Resources.erase;
            this.btnClear.Location = new System.Drawing.Point(313, 537);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(162, 60);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Очистить";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // picDistinguish
            // 
            this.picDistinguish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picDistinguish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDistinguish.Location = new System.Drawing.Point(25, 54);
            this.picDistinguish.Name = "picDistinguish";
            this.picDistinguish.Size = new System.Drawing.Size(450, 450);
            this.picDistinguish.TabIndex = 0;
            this.picDistinguish.TabStop = false;
            this.picDistinguish.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDistinguish_MouseDown);
            this.picDistinguish.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDistinguish_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1384, 663);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Distinguish Photos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageFin.ResumeLayout(false);
            this.tabPageFin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNumHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReadF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPixF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDistinguishF)).EndInit();
            this.tabPageBetween.ResumeLayout(false);
            this.tabPageBetween.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDataIndicate)).EndInit();
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.grRadioButtons.ResumeLayout(false);
            this.grRadioButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDistinguish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox picDistinguish;
        private System.Windows.Forms.TabPage tabPageBetween;
        private System.Windows.Forms.GroupBox grRadioButtons;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.TextBox txtPixColor;
        private System.Windows.Forms.Panel pnlColors;
        private System.Windows.Forms.PictureBox picPix;
        private System.Windows.Forms.PictureBox picRead;
        private System.Windows.Forms.RadioButton rb9;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb0;
        private System.Windows.Forms.Button btnToTxt;
        private System.Windows.Forms.TabPage tabPageFin;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnToData;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox picPixF;
        private System.Windows.Forms.PictureBox picDistinguishF;
        private System.Windows.Forms.PictureBox picReadF;
        private System.Windows.Forms.Panel pnlBW;
        private System.Windows.Forms.Panel pnlColorsF;
        private System.Windows.Forms.Button btnClearF;
        private System.Windows.Forms.Button btnReadF;
        private System.Windows.Forms.TextBox txtNumbersF;
        private System.Windows.Forms.Button btnFalseResult;
        private System.Windows.Forms.PictureBox picNumHigh;
        private System.Windows.Forms.PictureBox picDataIndicate;
        private System.Windows.Forms.TextBox txtDataIndicate;
        private System.Windows.Forms.RichTextBox rtxtPixColorF;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


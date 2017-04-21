namespace MiniKeyboard
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.txtBoxWordView = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lol = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.ModeButton = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnAsterisk = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnHashTag = new System.Windows.Forms.Button();
            this.ModeTxt = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.configureMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxKey7 = new System.Windows.Forms.ListBox();
            this.ButtonPressTimer = new System.Windows.Forms.Timer(this.components);
            this.listBoxKey8 = new System.Windows.Forms.ListBox();
            this.listBoxKey9 = new System.Windows.Forms.ListBox();
            this.listBoxKey4 = new System.Windows.Forms.ListBox();
            this.listBoxKey5 = new System.Windows.Forms.ListBox();
            this.listBoxKey6 = new System.Windows.Forms.ListBox();
            this.listBoxKey1 = new System.Windows.Forms.ListBox();
            this.listBoxKey2 = new System.Windows.Forms.ListBox();
            this.listBoxKey3 = new System.Windows.Forms.ListBox();
            this.listBoxKeyAsterisk = new System.Windows.Forms.ListBox();
            this.listBoxKeyHashTag = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(7, 36);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(575, 194);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.Text = "";
            // 
            // txtBoxWordView
            // 
            this.txtBoxWordView.Location = new System.Drawing.Point(159, 240);
            this.txtBoxWordView.Name = "txtBoxWordView";
            this.txtBoxWordView.Size = new System.Drawing.Size(189, 23);
            this.txtBoxWordView.TabIndex = 2;
            this.txtBoxWordView.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.LightGray;
            this.richTextBox3.Location = new System.Drawing.Point(159, 269);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(262, 285);
            this.richTextBox3.TabIndex = 3;
            this.richTextBox3.Text = "";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Yellow;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(354, 446);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(56, 104);
            this.btnEnter.TabIndex = 25;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lol
            // 
            this.lol.BackColor = System.Drawing.Color.Yellow;
            this.lol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lol.Location = new System.Drawing.Point(353, 281);
            this.lol.Name = "lol";
            this.lol.Size = new System.Drawing.Size(57, 49);
            this.lol.TabIndex = 34;
            this.lol.Text = "Send \r\nPre-\r\ndicted";
            this.lol.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(292, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 49);
            this.button4.TabIndex = 43;
            this.button4.Text = "Previous";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(230, 281);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(57, 49);
            this.button9.TabIndex = 44;
            this.button9.Text = "Next";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // ModeButton
            // 
            this.ModeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeButton.Location = new System.Drawing.Point(168, 281);
            this.ModeButton.Name = "ModeButton";
            this.ModeButton.Size = new System.Drawing.Size(57, 49);
            this.ModeButton.TabIndex = 45;
            this.ModeButton.Text = "Mode";
            this.ModeButton.UseVisualStyleBackColor = false;
            this.ModeButton.Click += new System.EventHandler(this.ModeClick_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(168, 336);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(57, 49);
            this.btn7.TabIndex = 49;
            this.btn7.Text = "7\r\n. , \"";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(230, 336);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(57, 49);
            this.btn8.TabIndex = 48;
            this.btn8.Text = "8\r\nA B C\r\n";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(292, 336);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(57, 49);
            this.btn9.TabIndex = 47;
            this.btn9.Text = "9\r\nD E F\r\n";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Yellow;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(353, 336);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 49);
            this.button6.TabIndex = 46;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(168, 391);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(57, 49);
            this.btn4.TabIndex = 53;
            this.btn4.Text = "4\r\nG H I\r\n";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(230, 391);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(57, 49);
            this.btn5.TabIndex = 52;
            this.btn5.Text = "5\r\nJ K L\r\n\r\n";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(292, 391);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(57, 49);
            this.btn6.TabIndex = 51;
            this.btn6.Text = "6\r\nM N O\r\n";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Yellow;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(353, 391);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(57, 49);
            this.button13.TabIndex = 50;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(168, 446);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(57, 49);
            this.btn1.TabIndex = 56;
            this.btn1.Text = "1\r\nP Q R S";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(230, 446);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(57, 49);
            this.btn2.TabIndex = 55;
            this.btn2.Text = "2\r\nT U V";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(292, 446);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(57, 49);
            this.btn3.TabIndex = 54;
            this.btn3.Text = "3\r\nW X Y Z";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnAsterisk
            // 
            this.btnAsterisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsterisk.Location = new System.Drawing.Point(168, 501);
            this.btnAsterisk.Name = "btnAsterisk";
            this.btnAsterisk.Size = new System.Drawing.Size(57, 49);
            this.btnAsterisk.TabIndex = 59;
            this.btnAsterisk.Text = "* - _";
            this.btnAsterisk.UseVisualStyleBackColor = false;
            this.btnAsterisk.Click += new System.EventHandler(this.btnAsterisk_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Lime;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(230, 501);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(57, 49);
            this.btn0.TabIndex = 58;
            this.btn0.Text = "000\r\n[ _ ]";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnHashTag
            // 
            this.btnHashTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHashTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHashTag.Location = new System.Drawing.Point(292, 501);
            this.btnHashTag.Name = "btnHashTag";
            this.btnHashTag.Size = new System.Drawing.Size(57, 49);
            this.btnHashTag.TabIndex = 57;
            this.btnHashTag.Text = "# \r\n0.00";
            this.btnHashTag.UseVisualStyleBackColor = false;
            this.btnHashTag.Click += new System.EventHandler(this.btnHashTag_Click);
            // 
            // ModeTxt
            // 
            this.ModeTxt.Location = new System.Drawing.Point(353, 240);
            this.ModeTxt.Name = "ModeTxt";
            this.ModeTxt.ReadOnly = true;
            this.ModeTxt.Size = new System.Drawing.Size(68, 20);
            this.ModeTxt.TabIndex = 60;
            this.ModeTxt.Text = "Multi-Press";
            this.ModeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configureMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 24);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.menuSave,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator3,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // oToolStripMenuItem
            // 
            this.oToolStripMenuItem.Name = "oToolStripMenuItem";
            this.oToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oToolStripMenuItem.Text = "New";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(152, 22);
            this.menuSave.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(152, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // configureMenu
            // 
            this.configureMenu.Name = "configureMenu";
            this.configureMenu.Size = new System.Drawing.Size(72, 20);
            this.configureMenu.Text = "Configure";
            this.configureMenu.Click += new System.EventHandler(this.configureMenu_Click);
            // 
            // listBoxKey7
            // 
            this.listBoxKey7.FormattingEnabled = true;
            this.listBoxKey7.Items.AddRange(new object[] {
            ".",
            "~",
            "\"",
            "7",
            "\'",
            ":",
            "; "});
            this.listBoxKey7.Location = new System.Drawing.Point(447, 296);
            this.listBoxKey7.Name = "listBoxKey7";
            this.listBoxKey7.Size = new System.Drawing.Size(29, 30);
            this.listBoxKey7.TabIndex = 4;
            this.listBoxKey7.Visible = false;
            // 
            // ButtonPressTimer
            // 
            this.ButtonPressTimer.Interval = 700;
            this.ButtonPressTimer.Tick += new System.EventHandler(this.ButtonPressTimer_Tick);
            // 
            // listBoxKey8
            // 
            this.listBoxKey8.FormattingEnabled = true;
            this.listBoxKey8.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "8",
            "A",
            "B",
            "C"});
            this.listBoxKey8.Location = new System.Drawing.Point(491, 296);
            this.listBoxKey8.Name = "listBoxKey8";
            this.listBoxKey8.Size = new System.Drawing.Size(29, 30);
            this.listBoxKey8.TabIndex = 62;
            this.listBoxKey8.Visible = false;
            // 
            // listBoxKey9
            // 
            this.listBoxKey9.FormattingEnabled = true;
            this.listBoxKey9.Items.AddRange(new object[] {
            "d",
            "e",
            "f",
            "9",
            "D",
            "E",
            "F"});
            this.listBoxKey9.Location = new System.Drawing.Point(535, 296);
            this.listBoxKey9.Name = "listBoxKey9";
            this.listBoxKey9.Size = new System.Drawing.Size(29, 30);
            this.listBoxKey9.TabIndex = 63;
            this.listBoxKey9.Visible = false;
            // 
            // listBoxKey4
            // 
            this.listBoxKey4.FormattingEnabled = true;
            this.listBoxKey4.Items.AddRange(new object[] {
            "g",
            "h",
            "i",
            "4",
            "G",
            "H",
            "I"});
            this.listBoxKey4.Location = new System.Drawing.Point(447, 336);
            this.listBoxKey4.Name = "listBoxKey4";
            this.listBoxKey4.Size = new System.Drawing.Size(29, 30);
            this.listBoxKey4.TabIndex = 64;
            this.listBoxKey4.Visible = false;
            // 
            // listBoxKey5
            // 
            this.listBoxKey5.FormattingEnabled = true;
            this.listBoxKey5.Items.AddRange(new object[] {
            "j",
            "k",
            "l",
            "5",
            "J",
            "K",
            "L"});
            this.listBoxKey5.Location = new System.Drawing.Point(491, 336);
            this.listBoxKey5.Name = "listBoxKey5";
            this.listBoxKey5.Size = new System.Drawing.Size(29, 30);
            this.listBoxKey5.TabIndex = 65;
            this.listBoxKey5.Visible = false;
            // 
            // listBoxKey6
            // 
            this.listBoxKey6.FormattingEnabled = true;
            this.listBoxKey6.Items.AddRange(new object[] {
            "m",
            "n",
            "o",
            "6",
            "M",
            "N",
            "O"});
            this.listBoxKey6.Location = new System.Drawing.Point(535, 336);
            this.listBoxKey6.Name = "listBoxKey6";
            this.listBoxKey6.Size = new System.Drawing.Size(29, 30);
            this.listBoxKey6.TabIndex = 66;
            this.listBoxKey6.Visible = false;
            // 
            // listBoxKey1
            // 
            this.listBoxKey1.FormattingEnabled = true;
            this.listBoxKey1.Items.AddRange(new object[] {
            "p",
            "q",
            "r",
            "s",
            "1",
            "P",
            "Q",
            "R",
            "S"});
            this.listBoxKey1.Location = new System.Drawing.Point(447, 372);
            this.listBoxKey1.Name = "listBoxKey1";
            this.listBoxKey1.Size = new System.Drawing.Size(29, 30);
            this.listBoxKey1.TabIndex = 67;
            this.listBoxKey1.Visible = false;
            // 
            // listBoxKey2
            // 
            this.listBoxKey2.FormattingEnabled = true;
            this.listBoxKey2.Items.AddRange(new object[] {
            "t",
            "u",
            "v",
            "2",
            "T",
            "U",
            "V"});
            this.listBoxKey2.Location = new System.Drawing.Point(491, 372);
            this.listBoxKey2.Name = "listBoxKey2";
            this.listBoxKey2.Size = new System.Drawing.Size(29, 30);
            this.listBoxKey2.TabIndex = 68;
            this.listBoxKey2.Visible = false;
            // 
            // listBoxKey3
            // 
            this.listBoxKey3.FormattingEnabled = true;
            this.listBoxKey3.Items.AddRange(new object[] {
            "t",
            "u",
            "v",
            "2",
            "T",
            "U",
            "V"});
            this.listBoxKey3.Location = new System.Drawing.Point(535, 372);
            this.listBoxKey3.Name = "listBoxKey3";
            this.listBoxKey3.Size = new System.Drawing.Size(29, 30);
            this.listBoxKey3.TabIndex = 69;
            this.listBoxKey3.Visible = false;
            // 
            // listBoxKeyAsterisk
            // 
            this.listBoxKeyAsterisk.FormattingEnabled = true;
            this.listBoxKeyAsterisk.Items.AddRange(new object[] {
            "*",
            "‐",
            "_"});
            this.listBoxKeyAsterisk.Location = new System.Drawing.Point(447, 408);
            this.listBoxKeyAsterisk.Name = "listBoxKeyAsterisk";
            this.listBoxKeyAsterisk.Size = new System.Drawing.Size(29, 30);
            this.listBoxKeyAsterisk.TabIndex = 70;
            this.listBoxKeyAsterisk.Visible = false;
            // 
            // listBoxKeyHashTag
            // 
            this.listBoxKeyHashTag.FormattingEnabled = true;
            this.listBoxKeyHashTag.Items.AddRange(new object[] {
            "#",
            "‐",
            "_"});
            this.listBoxKeyHashTag.Location = new System.Drawing.Point(535, 408);
            this.listBoxKeyHashTag.Name = "listBoxKeyHashTag";
            this.listBoxKeyHashTag.Size = new System.Drawing.Size(29, 30);
            this.listBoxKeyHashTag.TabIndex = 71;
            this.listBoxKeyHashTag.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 566);
            this.Controls.Add(this.listBoxKeyHashTag);
            this.Controls.Add(this.listBoxKeyAsterisk);
            this.Controls.Add(this.listBoxKey3);
            this.Controls.Add(this.listBoxKey2);
            this.Controls.Add(this.listBoxKey1);
            this.Controls.Add(this.listBoxKey6);
            this.Controls.Add(this.listBoxKey5);
            this.Controls.Add(this.listBoxKey4);
            this.Controls.Add(this.listBoxKey9);
            this.Controls.Add(this.listBoxKey8);
            this.Controls.Add(this.listBoxKey7);
            this.Controls.Add(this.ModeTxt);
            this.Controls.Add(this.btnAsterisk);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnHashTag);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ModeButton);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lol);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.txtBoxWordView);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mini Keyboard V1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.RichTextBox txtBoxWordView;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button lol;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button ModeButton;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnAsterisk;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnHashTag;
        private System.Windows.Forms.TextBox ModeTxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem configureMenu;
        private System.Windows.Forms.ListBox listBoxKey7;
        private System.Windows.Forms.Timer ButtonPressTimer;
        private System.Windows.Forms.ListBox listBoxKey8;
        private System.Windows.Forms.ListBox listBoxKey9;
        private System.Windows.Forms.ListBox listBoxKey4;
        private System.Windows.Forms.ListBox listBoxKey5;
        private System.Windows.Forms.ListBox listBoxKey6;
        private System.Windows.Forms.ListBox listBoxKey1;
        private System.Windows.Forms.ListBox listBoxKey2;
        private System.Windows.Forms.ListBox listBoxKey3;
        private System.Windows.Forms.ListBox listBoxKeyAsterisk;
        private System.Windows.Forms.ListBox listBoxKeyHashTag;
    }
}


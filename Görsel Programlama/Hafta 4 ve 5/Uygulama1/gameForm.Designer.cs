
namespace Uygulama1
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.LoginTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timerMem = new System.Windows.Forms.Timer(this.components);
            this.GamePage2 = new System.Windows.Forms.TabPage();
            this.minusAnswer = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.minusRight = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.minusLeft = new System.Windows.Forms.Label();
            this.plusAnswer = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.plusRight = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.plusLeft = new System.Windows.Forms.Label();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.TsGameStart2 = new System.Windows.Forms.ToolStripButton();
            this.lastTimer = new System.Windows.Forms.ToolStripLabel();
            this.GamePage1 = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.TsGameStart = new System.Windows.Forms.ToolStripButton();
            this.gameSec = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginPage = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Counter = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.miniGame1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miniGame2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAbout = new System.Windows.Forms.ToolStripButton();
            this.SCBTabCntrl = new System.Windows.Forms.TabControl();
            this.GamePage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minusAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusAnswer)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.GamePage1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SCBTabCntrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTimer
            // 
            this.LoginTimer.Interval = 1000;
            this.LoginTimer.Tick += new System.EventHandler(this.LoginTimer_Tick);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // timerMem
            // 
            this.timerMem.Interval = 1000;
            this.timerMem.Tick += new System.EventHandler(this.TimerMem_Tick);
            // 
            // GamePage2
            // 
            this.GamePage2.Controls.Add(this.minusAnswer);
            this.GamePage2.Controls.Add(this.label21);
            this.GamePage2.Controls.Add(this.minusRight);
            this.GamePage2.Controls.Add(this.label23);
            this.GamePage2.Controls.Add(this.minusLeft);
            this.GamePage2.Controls.Add(this.plusAnswer);
            this.GamePage2.Controls.Add(this.label20);
            this.GamePage2.Controls.Add(this.plusRight);
            this.GamePage2.Controls.Add(this.label19);
            this.GamePage2.Controls.Add(this.plusLeft);
            this.GamePage2.Controls.Add(this.toolStrip3);
            this.GamePage2.Location = new System.Drawing.Point(4, 22);
            this.GamePage2.Name = "GamePage2";
            this.GamePage2.Size = new System.Drawing.Size(792, 424);
            this.GamePage2.TabIndex = 2;
            this.GamePage2.Text = "MiniGame 2";
            this.GamePage2.UseVisualStyleBackColor = true;
            // 
            // minusAnswer
            // 
            this.minusAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minusAnswer.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.minusAnswer.Location = new System.Drawing.Point(221, 123);
            this.minusAnswer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.minusAnswer.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.minusAnswer.Name = "minusAnswer";
            this.minusAnswer.Size = new System.Drawing.Size(120, 26);
            this.minusAnswer.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(182, 128);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 16);
            this.label21.TabIndex = 9;
            this.label21.Text = "=";
            // 
            // minusRight
            // 
            this.minusRight.AutoSize = true;
            this.minusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minusRight.Location = new System.Drawing.Point(118, 126);
            this.minusRight.Name = "minusRight";
            this.minusRight.Size = new System.Drawing.Size(42, 20);
            this.minusRight.TabIndex = 8;
            this.minusRight.Text = "Num";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(69, 129);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(12, 16);
            this.label23.TabIndex = 7;
            this.label23.Text = "-";
            // 
            // minusLeft
            // 
            this.minusLeft.AutoSize = true;
            this.minusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minusLeft.Location = new System.Drawing.Point(8, 126);
            this.minusLeft.Name = "minusLeft";
            this.minusLeft.Size = new System.Drawing.Size(42, 20);
            this.minusLeft.TabIndex = 6;
            this.minusLeft.Text = "Num";
            // 
            // plusAnswer
            // 
            this.plusAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plusAnswer.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.plusAnswer.Location = new System.Drawing.Point(221, 74);
            this.plusAnswer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.plusAnswer.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.plusAnswer.Name = "plusAnswer";
            this.plusAnswer.Size = new System.Drawing.Size(120, 26);
            this.plusAnswer.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(182, 79);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 16);
            this.label20.TabIndex = 4;
            this.label20.Text = "=";
            // 
            // plusRight
            // 
            this.plusRight.AutoSize = true;
            this.plusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plusRight.Location = new System.Drawing.Point(118, 77);
            this.plusRight.Name = "plusRight";
            this.plusRight.Size = new System.Drawing.Size(42, 20);
            this.plusRight.TabIndex = 3;
            this.plusRight.Text = "Num";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(69, 80);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 16);
            this.label19.TabIndex = 2;
            this.label19.Text = "+";
            // 
            // plusLeft
            // 
            this.plusLeft.AutoSize = true;
            this.plusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plusLeft.Location = new System.Drawing.Point(8, 77);
            this.plusLeft.Name = "plusLeft";
            this.plusLeft.Size = new System.Drawing.Size(42, 20);
            this.plusLeft.TabIndex = 1;
            this.plusLeft.Text = "Num";
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsGameStart2,
            this.lastTimer});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(792, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // TsGameStart2
            // 
            this.TsGameStart2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsGameStart2.Image = ((System.Drawing.Image)(resources.GetObject("TsGameStart2.Image")));
            this.TsGameStart2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsGameStart2.Name = "TsGameStart2";
            this.TsGameStart2.Size = new System.Drawing.Size(35, 22);
            this.TsGameStart2.Text = "Start";
            this.TsGameStart2.Click += new System.EventHandler(this.TsGameStart2_Click);
            // 
            // lastTimer
            // 
            this.lastTimer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lastTimer.Name = "lastTimer";
            this.lastTimer.Size = new System.Drawing.Size(0, 22);
            // 
            // GamePage1
            // 
            this.GamePage1.Controls.Add(this.toolStrip2);
            this.GamePage1.Controls.Add(this.tableLayoutPanel1);
            this.GamePage1.Location = new System.Drawing.Point(4, 22);
            this.GamePage1.Name = "GamePage1";
            this.GamePage1.Padding = new System.Windows.Forms.Padding(3);
            this.GamePage1.Size = new System.Drawing.Size(792, 424);
            this.GamePage1.TabIndex = 1;
            this.GamePage1.Text = "Mini Game";
            this.GamePage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsGameStart,
            this.gameSec});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(786, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // TsGameStart
            // 
            this.TsGameStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsGameStart.Image = ((System.Drawing.Image)(resources.GetObject("TsGameStart.Image")));
            this.TsGameStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsGameStart.Name = "TsGameStart";
            this.TsGameStart.Size = new System.Drawing.Size(35, 22);
            this.TsGameStart.Text = "Start";
            this.TsGameStart.Click += new System.EventHandler(this.TsGameStart_Click);
            // 
            // gameSec
            // 
            this.gameSec.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.gameSec.ForeColor = System.Drawing.Color.Red;
            this.gameSec.Name = "gameSec";
            this.gameSec.Size = new System.Drawing.Size(0, 22);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightCoral;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label18, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label17, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label16, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label14, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-4, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 393);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Firebrick;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(603, 297);
            this.label18.Margin = new System.Windows.Forms.Padding(3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(194, 93);
            this.label18.TabIndex = 15;
            this.label18.Text = "Ş";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.Click += new System.EventHandler(this.Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Firebrick;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(403, 297);
            this.label17.Margin = new System.Windows.Forms.Padding(3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(194, 93);
            this.label17.TabIndex = 14;
            this.label17.Text = "Ş";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Click += new System.EventHandler(this.Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Firebrick;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(203, 297);
            this.label16.Margin = new System.Windows.Forms.Padding(3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(194, 93);
            this.label16.TabIndex = 13;
            this.label16.Text = "Ş";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Firebrick;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(3, 297);
            this.label15.Margin = new System.Windows.Forms.Padding(3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(194, 93);
            this.label15.TabIndex = 12;
            this.label15.Text = "Ş";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Firebrick;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(603, 199);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(194, 92);
            this.label14.TabIndex = 11;
            this.label14.Text = "Ş";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Firebrick;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(403, 199);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 92);
            this.label13.TabIndex = 10;
            this.label13.Text = "Ş";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Firebrick;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(203, 199);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 92);
            this.label12.TabIndex = 9;
            this.label12.Text = "Ş";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Firebrick;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(3, 199);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 92);
            this.label11.TabIndex = 8;
            this.label11.Text = "Ş";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Firebrick;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(603, 101);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 92);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ş";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Firebrick;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(403, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 92);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ş";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Firebrick;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(203, 101);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 92);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ş";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Firebrick;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 92);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ş";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Firebrick;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(603, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 92);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ş";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Firebrick;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(403, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 92);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ş";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Firebrick;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(203, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 92);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ş";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Firebrick;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 92);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ş";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.Click);
            // 
            // LoginPage
            // 
            this.LoginPage.Controls.Add(this.textBox1);
            this.LoginPage.Controls.Add(this.button1);
            this.LoginPage.Controls.Add(this.label1);
            this.LoginPage.Controls.Add(this.statusStrip1);
            this.LoginPage.Controls.Add(this.toolStrip1);
            this.LoginPage.Location = new System.Drawing.Point(4, 22);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoginPage.Size = new System.Drawing.Size(792, 424);
            this.LoginPage.TabIndex = 0;
            this.LoginPage.Text = "Login";
            this.LoginPage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Counter});
            this.statusStrip1.Location = new System.Drawing.Point(3, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(786, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Counter
            // 
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.userAbout});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(786, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miniGame1ToolStripMenuItem,
            this.miniGame2ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(85, 22);
            this.toolStripDropDownButton1.Text = "Select Game";
            // 
            // miniGame1ToolStripMenuItem
            // 
            this.miniGame1ToolStripMenuItem.Name = "miniGame1ToolStripMenuItem";
            this.miniGame1ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.miniGame1ToolStripMenuItem.Text = "Match Game";
            this.miniGame1ToolStripMenuItem.Click += new System.EventHandler(this.MiniGame1ToolStripMenuItem_Click);
            // 
            // miniGame2ToolStripMenuItem
            // 
            this.miniGame2ToolStripMenuItem.Name = "miniGame2ToolStripMenuItem";
            this.miniGame2ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.miniGame2ToolStripMenuItem.Text = "Math Quiz Game";
            this.miniGame2ToolStripMenuItem.Click += new System.EventHandler(this.MiniGame2ToolStripMenuItem_Click);
            // 
            // userAbout
            // 
            this.userAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.userAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.userAbout.Image = ((System.Drawing.Image)(resources.GetObject("userAbout.Image")));
            this.userAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userAbout.Name = "userAbout";
            this.userAbout.Size = new System.Drawing.Size(70, 22);
            this.userAbout.Text = "User About";
            this.userAbout.Click += new System.EventHandler(this.UserAbout_Click);
            // 
            // SCBTabCntrl
            // 
            this.SCBTabCntrl.Controls.Add(this.LoginPage);
            this.SCBTabCntrl.Controls.Add(this.GamePage1);
            this.SCBTabCntrl.Controls.Add(this.GamePage2);
            this.SCBTabCntrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCBTabCntrl.Location = new System.Drawing.Point(0, 0);
            this.SCBTabCntrl.Name = "SCBTabCntrl";
            this.SCBTabCntrl.SelectedIndex = 0;
            this.SCBTabCntrl.Size = new System.Drawing.Size(800, 450);
            this.SCBTabCntrl.TabIndex = 0;
            this.SCBTabCntrl.SelectedIndexChanged += new System.EventHandler(this.SCBTabCntrl_SelectedIndexChanged);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SCBTabCntrl);
            this.Name = "GameForm";
            this.Text = "SCBHomework";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GamePage2.ResumeLayout(false);
            this.GamePage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minusAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusAnswer)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.GamePage1.ResumeLayout(false);
            this.GamePage1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.SCBTabCntrl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer LoginTimer;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer timerMem;
        private System.Windows.Forms.TabPage GamePage2;
        private System.Windows.Forms.NumericUpDown plusAnswer;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label plusRight;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label plusLeft;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton TsGameStart2;
        private System.Windows.Forms.ToolStripLabel lastTimer;
        private System.Windows.Forms.TabPage GamePage1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton TsGameStart;
        private System.Windows.Forms.ToolStripLabel gameSec;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage LoginPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Counter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem miniGame1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miniGame2ToolStripMenuItem;
        private System.Windows.Forms.TabControl SCBTabCntrl;
        private System.Windows.Forms.NumericUpDown minusAnswer;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label minusRight;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label minusLeft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripButton userAbout;
    }
}


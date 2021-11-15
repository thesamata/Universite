
namespace Uygulama_1
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
            this.scbBtn1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaiceriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaAdıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaDuzen = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textLog = new System.Windows.Forms.TextBox();
            this.scbBtn2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scbBtn1
            // 
            this.scbBtn1.Location = new System.Drawing.Point(644, 234);
            this.scbBtn1.Name = "scbBtn1";
            this.scbBtn1.Size = new System.Drawing.Size(144, 49);
            this.scbBtn1.TabIndex = 0;
            this.scbBtn1.Text = "MessageBox Durdur Yeniden Dene Yoksay";
            this.scbBtn1.UseVisualStyleBackColor = true;
            this.scbBtn1.Click += new System.EventHandler(this.scbBtn1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaMenu,
            this.dosyaDuzen,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaMenu
            // 
            this.dosyaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.acToolStripMenuItem});
            this.dosyaMenu.Name = "dosyaMenu";
            this.dosyaMenu.Size = new System.Drawing.Size(51, 20);
            this.dosyaMenu.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            // 
            // acToolStripMenuItem
            // 
            this.acToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaiceriToolStripMenuItem,
            this.dosyaAdıToolStripMenuItem});
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.acToolStripMenuItem.Text = "Aç..";
            // 
            // dosyaiceriToolStripMenuItem
            // 
            this.dosyaiceriToolStripMenuItem.Name = "dosyaiceriToolStripMenuItem";
            this.dosyaiceriToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.dosyaiceriToolStripMenuItem.Text = "Dosya İçeri";
            this.dosyaiceriToolStripMenuItem.Click += new System.EventHandler(this.dosyaiceriToolStripMenuItem_Click);
            // 
            // dosyaAdıToolStripMenuItem
            // 
            this.dosyaAdıToolStripMenuItem.Name = "dosyaAdıToolStripMenuItem";
            this.dosyaAdıToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.dosyaAdıToolStripMenuItem.Text = "Dosya Adı";
            this.dosyaAdıToolStripMenuItem.Click += new System.EventHandler(this.dosyaAdıToolStripMenuItem_Click);
            // 
            // dosyaDuzen
            // 
            this.dosyaDuzen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem});
            this.dosyaDuzen.Name = "dosyaDuzen";
            this.dosyaDuzen.Size = new System.Drawing.Size(52, 20);
            this.dosyaDuzen.Text = "Düzen";
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
            // 
            // textLog
            // 
            this.textLog.AcceptsReturn = true;
            this.textLog.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textLog.Location = new System.Drawing.Point(12, 289);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ReadOnly = true;
            this.textLog.Size = new System.Drawing.Size(776, 132);
            this.textLog.TabIndex = 2;
            // 
            // scbBtn2
            // 
            this.scbBtn2.Location = new System.Drawing.Point(12, 234);
            this.scbBtn2.Name = "scbBtn2";
            this.scbBtn2.Size = new System.Drawing.Size(144, 49);
            this.scbBtn2.TabIndex = 3;
            this.scbBtn2.Text = "MessageBox Evet Hayır";
            this.scbBtn2.UseVisualStyleBackColor = true;
            this.scbBtn2.Click += new System.EventHandler(this.scbBtn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scbBtn2);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.scbBtn1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SCB Odev";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scbBtn1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.Button scbBtn2;
        private System.Windows.Forms.ToolStripMenuItem dosyaMenu;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaDuzen;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaiceriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaAdıToolStripMenuItem;
    }
}


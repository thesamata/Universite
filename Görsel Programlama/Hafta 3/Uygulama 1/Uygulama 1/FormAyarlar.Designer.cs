
namespace Uygulama_1
{
    partial class FormAyarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAyarlar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scbBtn1 = new System.Windows.Forms.Button();
            this.scbBtn2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.uygulaTlStripBtn = new System.Windows.Forms.ToolStripButton();
            this.vazgecTlStripBtn = new System.Windows.Forms.ToolStripButton();
            this.previewColor = new System.Windows.Forms.Panel();
            this.previewFont = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arka plan rengi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Font Tipi :";
            // 
            // scbBtn1
            // 
            this.scbBtn1.Location = new System.Drawing.Point(144, 74);
            this.scbBtn1.Name = "scbBtn1";
            this.scbBtn1.Size = new System.Drawing.Size(39, 28);
            this.scbBtn1.TabIndex = 2;
            this.scbBtn1.UseVisualStyleBackColor = true;
            this.scbBtn1.Click += new System.EventHandler(this.scbBtn1_Click);
            // 
            // scbBtn2
            // 
            this.scbBtn2.Location = new System.Drawing.Point(144, 116);
            this.scbBtn2.Name = "scbBtn2";
            this.scbBtn2.Size = new System.Drawing.Size(39, 28);
            this.scbBtn2.TabIndex = 3;
            this.scbBtn2.UseVisualStyleBackColor = true;
            this.scbBtn2.Click += new System.EventHandler(this.scbBtn2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uygulaTlStripBtn,
            this.vazgecTlStripBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(423, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // uygulaTlStripBtn
            // 
            this.uygulaTlStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("uygulaTlStripBtn.Image")));
            this.uygulaTlStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uygulaTlStripBtn.Name = "uygulaTlStripBtn";
            this.uygulaTlStripBtn.Size = new System.Drawing.Size(64, 22);
            this.uygulaTlStripBtn.Text = "Uygula";
            this.uygulaTlStripBtn.Click += new System.EventHandler(this.uygulaTlStripBtn_Click);
            // 
            // vazgecTlStripBtn
            // 
            this.vazgecTlStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("vazgecTlStripBtn.Image")));
            this.vazgecTlStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.vazgecTlStripBtn.Name = "vazgecTlStripBtn";
            this.vazgecTlStripBtn.Size = new System.Drawing.Size(63, 22);
            this.vazgecTlStripBtn.Text = "Vazgeç";
            this.vazgecTlStripBtn.Click += new System.EventHandler(this.vazgecTlStripBtn_Click);
            // 
            // previewColor
            // 
            this.previewColor.Location = new System.Drawing.Point(205, 12);
            this.previewColor.Name = "previewColor";
            this.previewColor.Size = new System.Drawing.Size(206, 90);
            this.previewColor.TabIndex = 5;
            // 
            // previewFont
            // 
            this.previewFont.AutoSize = true;
            this.previewFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.previewFont.Location = new System.Drawing.Point(271, 116);
            this.previewFont.Name = "previewFont";
            this.previewFont.Size = new System.Drawing.Size(48, 24);
            this.previewFont.TabIndex = 6;
            this.previewFont.Text = "ABC";
            // 
            // FormAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 219);
            this.Controls.Add(this.previewFont);
            this.Controls.Add(this.previewColor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.scbBtn2);
            this.Controls.Add(this.scbBtn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "FormAyarlar";
            this.Text = "Seçenekler";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button scbBtn1;
        private System.Windows.Forms.Button scbBtn2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton uygulaTlStripBtn;
        private System.Windows.Forms.ToolStripButton vazgecTlStripBtn;
        private System.Windows.Forms.Panel previewColor;
        private System.Windows.Forms.Label previewFont;
    }
}

namespace PASSWORD_GENERATOR
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chcboxsekil = new System.Windows.Forms.CheckBox();
            this.chcboxBuyuk = new System.Windows.Forms.CheckBox();
            this.chcboxsayi = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Üretmek istediğiniz parola özellikleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola Uzunluğu : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "Üret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chcboxsekil
            // 
            this.chcboxsekil.AutoSize = true;
            this.chcboxsekil.Location = new System.Drawing.Point(269, 49);
            this.chcboxsekil.Name = "chcboxsekil";
            this.chcboxsekil.Size = new System.Drawing.Size(98, 28);
            this.chcboxsekil.TabIndex = 5;
            this.chcboxsekil.Text = "Şekiller";
            this.chcboxsekil.UseVisualStyleBackColor = true;
            // 
            // chcboxBuyuk
            // 
            this.chcboxBuyuk.AutoSize = true;
            this.chcboxBuyuk.Location = new System.Drawing.Point(24, 49);
            this.chcboxBuyuk.Name = "chcboxBuyuk";
            this.chcboxBuyuk.Size = new System.Drawing.Size(130, 28);
            this.chcboxBuyuk.TabIndex = 6;
            this.chcboxBuyuk.Text = "Büyük Harf";
            this.chcboxBuyuk.UseVisualStyleBackColor = true;
            // 
            // chcboxsayi
            // 
            this.chcboxsayi.AutoSize = true;
            this.chcboxsayi.Location = new System.Drawing.Point(175, 49);
            this.chcboxsayi.Name = "chcboxsayi";
            this.chcboxsayi.Size = new System.Drawing.Size(68, 28);
            this.chcboxsayi.TabIndex = 7;
            this.chcboxsayi.Text = "Sayı";
            this.chcboxsayi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 8;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(55, 131);
            this.hScrollBar1.Maximum = 35;
            this.hScrollBar1.Minimum = 3;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(281, 24);
            this.hScrollBar1.TabIndex = 9;
            this.hScrollBar1.Value = 3;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(390, 295);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chcboxsayi);
            this.Controls.Add(this.chcboxBuyuk);
            this.Controls.Add(this.chcboxsekil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chcboxsekil;
        private System.Windows.Forms.CheckBox chcboxBuyuk;
        private System.Windows.Forms.CheckBox chcboxsayi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}


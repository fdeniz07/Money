
namespace WindowsFormsApp1
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
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtNakitPara = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl50TL = new System.Windows.Forms.Label();
            this.lbl10TL = new System.Windows.Forms.Label();
            this.lbl5TL = new System.Windows.Forms.Label();
            this.lbl1TL = new System.Windows.Forms.Label();
            this.lblParaUstu = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl100TL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(187, 25);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(140, 22);
            this.txtTutar.TabIndex = 0;
            // 
            // txtNakitPara
            // 
            this.txtNakitPara.Location = new System.Drawing.Point(187, 60);
            this.txtNakitPara.Name = "txtNakitPara";
            this.txtNakitPara.Size = new System.Drawing.Size(140, 22);
            this.txtNakitPara.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl50TL
            // 
            this.lbl50TL.AutoSize = true;
            this.lbl50TL.Location = new System.Drawing.Point(266, 96);
            this.lbl50TL.Name = "lbl50TL";
            this.lbl50TL.Size = new System.Drawing.Size(16, 16);
            this.lbl50TL.TabIndex = 3;
            this.lbl50TL.Text = "0";
            // 
            // lbl10TL
            // 
            this.lbl10TL.AutoSize = true;
            this.lbl10TL.Location = new System.Drawing.Point(192, 98);
            this.lbl10TL.Name = "lbl10TL";
            this.lbl10TL.Size = new System.Drawing.Size(16, 16);
            this.lbl10TL.TabIndex = 4;
            this.lbl10TL.Text = "0";
            // 
            // lbl5TL
            // 
            this.lbl5TL.AutoSize = true;
            this.lbl5TL.Location = new System.Drawing.Point(117, 98);
            this.lbl5TL.Name = "lbl5TL";
            this.lbl5TL.Size = new System.Drawing.Size(16, 16);
            this.lbl5TL.TabIndex = 5;
            this.lbl5TL.Text = "0";
            // 
            // lbl1TL
            // 
            this.lbl1TL.AutoSize = true;
            this.lbl1TL.Location = new System.Drawing.Point(56, 98);
            this.lbl1TL.Name = "lbl1TL";
            this.lbl1TL.Size = new System.Drawing.Size(16, 16);
            this.lbl1TL.TabIndex = 5;
            this.lbl1TL.Text = "0";
            // 
            // lblParaUstu
            // 
            this.lblParaUstu.AutoSize = true;
            this.lblParaUstu.Location = new System.Drawing.Point(231, 139);
            this.lblParaUstu.Name = "lblParaUstu";
            this.lblParaUstu.Size = new System.Drawing.Size(16, 16);
            this.lblParaUstu.TabIndex = 6;
            this.lblParaUstu.Text = "0";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(82, 222);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(222, 222);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Toplam Tutar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Verilen Nakit Para :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Para Üstü :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNakitPara);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblParaUstu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 169);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KASA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbl100TL);
            this.groupBox2.Controls.Add(this.lbl1TL);
            this.groupBox2.Controls.Add(this.lbl50TL);
            this.groupBox2.Controls.Add(this.lbl10TL);
            this.groupBox2.Controls.Add(this.lbl5TL);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(374, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 169);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PARA ÜSTÜ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "100 TL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "50 TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "10 TL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "5 TL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "1 TL";
            // 
            // lbl100TL
            // 
            this.lbl100TL.AutoSize = true;
            this.lbl100TL.Location = new System.Drawing.Point(340, 96);
            this.lbl100TL.Name = "lbl100TL";
            this.lbl100TL.Size = new System.Drawing.Size(16, 16);
            this.lbl100TL.TabIndex = 3;
            this.lbl100TL.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Para Türü";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(219, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Para Miktari";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(82, 324);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(260, 23);
            this.btnTemizle.TabIndex = 15;
            this.btnTemizle.Text = "TEMIZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtNakitPara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl50TL;
        private System.Windows.Forms.Label lbl10TL;
        private System.Windows.Forms.Label lbl5TL;
        private System.Windows.Forms.Label lbl1TL;
        private System.Windows.Forms.Label lblParaUstu;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl100TL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTemizle;
    }
}


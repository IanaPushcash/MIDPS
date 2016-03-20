namespace Calculator
{
    partial class Calc
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb = new System.Windows.Forms.TextBox();
            this.but_C = new System.Windows.Forms.Button();
            this.but_CE = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.but_7 = new System.Windows.Forms.Button();
            this.but_8 = new System.Windows.Forms.Button();
            this.but_9 = new System.Windows.Forms.Button();
            this.but_div = new System.Windows.Forms.Button();
            this.but_inv = new System.Windows.Forms.Button();
            this.but_sqrt = new System.Windows.Forms.Button();
            this.but_mult = new System.Windows.Forms.Button();
            this.but_6 = new System.Windows.Forms.Button();
            this.but_5 = new System.Windows.Forms.Button();
            this.but_4 = new System.Windows.Forms.Button();
            this.but_pow = new System.Windows.Forms.Button();
            this.but_min = new System.Windows.Forms.Button();
            this.but_3 = new System.Windows.Forms.Button();
            this.but_2 = new System.Windows.Forms.Button();
            this.but_1 = new System.Windows.Forms.Button();
            this.but_eq = new System.Windows.Forms.Button();
            this.but_plus = new System.Windows.Forms.Button();
            this.but_dot = new System.Windows.Forms.Button();
            this.but_0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb.Enabled = false;
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb.Location = new System.Drawing.Point(12, 12);
            this.tb.MaxLength = 15;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(212, 29);
            this.tb.TabIndex = 0;
            this.tb.Text = "0";
            this.tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb.WordWrap = false;
            // 
            // but_C
            // 
            this.but_C.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_C.Location = new System.Drawing.Point(12, 47);
            this.but_C.Name = "but_C";
            this.but_C.Size = new System.Drawing.Size(68, 32);
            this.but_C.TabIndex = 1;
            this.but_C.Text = "C";
            this.but_C.UseVisualStyleBackColor = true;
            this.but_C.Click += new System.EventHandler(this.but_C_Click);
            // 
            // but_CE
            // 
            this.but_CE.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_CE.Location = new System.Drawing.Point(84, 47);
            this.but_CE.Name = "but_CE";
            this.but_CE.Size = new System.Drawing.Size(68, 32);
            this.but_CE.TabIndex = 2;
            this.but_CE.Text = "CE";
            this.but_CE.UseVisualStyleBackColor = true;
            this.but_CE.Click += new System.EventHandler(this.but_CE_Click);
            // 
            // Del
            // 
            this.Del.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del.Location = new System.Drawing.Point(156, 47);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(68, 32);
            this.Del.TabIndex = 3;
            this.Del.Text = "<---";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // but_7
            // 
            this.but_7.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_7.Location = new System.Drawing.Point(12, 85);
            this.but_7.Name = "but_7";
            this.but_7.Size = new System.Drawing.Size(37, 31);
            this.but_7.TabIndex = 4;
            this.but_7.Text = "7";
            this.but_7.UseVisualStyleBackColor = true;
            this.but_7.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_8
            // 
            this.but_8.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_8.Location = new System.Drawing.Point(55, 85);
            this.but_8.Name = "but_8";
            this.but_8.Size = new System.Drawing.Size(37, 31);
            this.but_8.TabIndex = 5;
            this.but_8.Text = "8";
            this.but_8.UseVisualStyleBackColor = true;
            this.but_8.Click += new System.EventHandler(this.button2_Click);
            // 
            // but_9
            // 
            this.but_9.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_9.Location = new System.Drawing.Point(98, 85);
            this.but_9.Name = "but_9";
            this.but_9.Size = new System.Drawing.Size(37, 31);
            this.but_9.TabIndex = 6;
            this.but_9.Text = "9";
            this.but_9.UseVisualStyleBackColor = true;
            this.but_9.Click += new System.EventHandler(this.but_9_Click);
            // 
            // but_div
            // 
            this.but_div.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_div.Location = new System.Drawing.Point(144, 85);
            this.but_div.Name = "but_div";
            this.but_div.Size = new System.Drawing.Size(37, 31);
            this.but_div.TabIndex = 7;
            this.but_div.Text = "/";
            this.but_div.UseVisualStyleBackColor = true;
            this.but_div.Click += new System.EventHandler(this.but_div_Click);
            // 
            // but_inv
            // 
            this.but_inv.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_inv.Location = new System.Drawing.Point(187, 85);
            this.but_inv.Name = "but_inv";
            this.but_inv.Size = new System.Drawing.Size(37, 31);
            this.but_inv.TabIndex = 8;
            this.but_inv.Text = "+/-";
            this.but_inv.UseVisualStyleBackColor = true;
            this.but_inv.Click += new System.EventHandler(this.but_inv_Click);
            // 
            // but_sqrt
            // 
            this.but_sqrt.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_sqrt.Location = new System.Drawing.Point(187, 122);
            this.but_sqrt.Name = "but_sqrt";
            this.but_sqrt.Size = new System.Drawing.Size(37, 31);
            this.but_sqrt.TabIndex = 13;
            this.but_sqrt.Text = "sqrt";
            this.but_sqrt.UseVisualStyleBackColor = true;
            this.but_sqrt.Click += new System.EventHandler(this.but_sqrt_Click);
            // 
            // but_mult
            // 
            this.but_mult.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_mult.Location = new System.Drawing.Point(144, 122);
            this.but_mult.Name = "but_mult";
            this.but_mult.Size = new System.Drawing.Size(37, 31);
            this.but_mult.TabIndex = 12;
            this.but_mult.Text = "*";
            this.but_mult.UseVisualStyleBackColor = true;
            this.but_mult.Click += new System.EventHandler(this.but_mult_Click);
            // 
            // but_6
            // 
            this.but_6.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_6.Location = new System.Drawing.Point(98, 122);
            this.but_6.Name = "but_6";
            this.but_6.Size = new System.Drawing.Size(37, 31);
            this.but_6.TabIndex = 11;
            this.but_6.Text = "6";
            this.but_6.UseVisualStyleBackColor = true;
            this.but_6.Click += new System.EventHandler(this.but_6_Click);
            // 
            // but_5
            // 
            this.but_5.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_5.Location = new System.Drawing.Point(55, 122);
            this.but_5.Name = "but_5";
            this.but_5.Size = new System.Drawing.Size(37, 31);
            this.but_5.TabIndex = 10;
            this.but_5.Text = "5";
            this.but_5.UseVisualStyleBackColor = true;
            this.but_5.Click += new System.EventHandler(this.but_5_Click);
            // 
            // but_4
            // 
            this.but_4.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_4.Location = new System.Drawing.Point(12, 122);
            this.but_4.Name = "but_4";
            this.but_4.Size = new System.Drawing.Size(37, 31);
            this.but_4.TabIndex = 9;
            this.but_4.Text = "4";
            this.but_4.UseVisualStyleBackColor = true;
            this.but_4.Click += new System.EventHandler(this.but_4_Click);
            // 
            // but_pow
            // 
            this.but_pow.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_pow.Location = new System.Drawing.Point(187, 159);
            this.but_pow.Name = "but_pow";
            this.but_pow.Size = new System.Drawing.Size(37, 31);
            this.but_pow.TabIndex = 18;
            this.but_pow.Text = "^";
            this.but_pow.UseVisualStyleBackColor = true;
            this.but_pow.Click += new System.EventHandler(this.but_pow_Click);
            // 
            // but_min
            // 
            this.but_min.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_min.Location = new System.Drawing.Point(144, 159);
            this.but_min.Name = "but_min";
            this.but_min.Size = new System.Drawing.Size(37, 31);
            this.but_min.TabIndex = 17;
            this.but_min.Text = "-";
            this.but_min.UseVisualStyleBackColor = true;
            this.but_min.Click += new System.EventHandler(this.but_min_Click);
            // 
            // but_3
            // 
            this.but_3.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_3.Location = new System.Drawing.Point(98, 159);
            this.but_3.Name = "but_3";
            this.but_3.Size = new System.Drawing.Size(37, 31);
            this.but_3.TabIndex = 16;
            this.but_3.Text = "3";
            this.but_3.UseVisualStyleBackColor = true;
            this.but_3.Click += new System.EventHandler(this.but_3_Click);
            // 
            // but_2
            // 
            this.but_2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_2.Location = new System.Drawing.Point(55, 159);
            this.but_2.Name = "but_2";
            this.but_2.Size = new System.Drawing.Size(37, 31);
            this.but_2.TabIndex = 15;
            this.but_2.Text = "2";
            this.but_2.UseVisualStyleBackColor = true;
            this.but_2.Click += new System.EventHandler(this.but_2_Click);
            // 
            // but_1
            // 
            this.but_1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_1.Location = new System.Drawing.Point(12, 159);
            this.but_1.Name = "but_1";
            this.but_1.Size = new System.Drawing.Size(37, 31);
            this.but_1.TabIndex = 14;
            this.but_1.Text = "1";
            this.but_1.UseVisualStyleBackColor = true;
            this.but_1.Click += new System.EventHandler(this.but_1_Click);
            // 
            // but_eq
            // 
            this.but_eq.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_eq.Location = new System.Drawing.Point(187, 196);
            this.but_eq.Name = "but_eq";
            this.but_eq.Size = new System.Drawing.Size(37, 31);
            this.but_eq.TabIndex = 23;
            this.but_eq.Text = "=";
            this.but_eq.UseVisualStyleBackColor = true;
            this.but_eq.Click += new System.EventHandler(this.but_eq_Click);
            // 
            // but_plus
            // 
            this.but_plus.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_plus.Location = new System.Drawing.Point(144, 196);
            this.but_plus.Name = "but_plus";
            this.but_plus.Size = new System.Drawing.Size(37, 31);
            this.but_plus.TabIndex = 22;
            this.but_plus.Text = "+";
            this.but_plus.UseVisualStyleBackColor = true;
            this.but_plus.Click += new System.EventHandler(this.but_plus_Click);
            // 
            // but_dot
            // 
            this.but_dot.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_dot.Location = new System.Drawing.Point(98, 196);
            this.but_dot.Name = "but_dot";
            this.but_dot.Size = new System.Drawing.Size(37, 31);
            this.but_dot.TabIndex = 21;
            this.but_dot.Text = ",";
            this.but_dot.UseVisualStyleBackColor = true;
            this.but_dot.Click += new System.EventHandler(this.but_dot_Click);
            // 
            // but_0
            // 
            this.but_0.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_0.Location = new System.Drawing.Point(12, 196);
            this.but_0.Name = "but_0";
            this.but_0.Size = new System.Drawing.Size(80, 31);
            this.but_0.TabIndex = 20;
            this.but_0.Text = "0";
            this.but_0.UseVisualStyleBackColor = true;
            this.but_0.Click += new System.EventHandler(this.but_0_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(236, 232);
            this.Controls.Add(this.but_eq);
            this.Controls.Add(this.but_plus);
            this.Controls.Add(this.but_dot);
            this.Controls.Add(this.but_0);
            this.Controls.Add(this.but_pow);
            this.Controls.Add(this.but_min);
            this.Controls.Add(this.but_3);
            this.Controls.Add(this.but_2);
            this.Controls.Add(this.but_1);
            this.Controls.Add(this.but_sqrt);
            this.Controls.Add(this.but_mult);
            this.Controls.Add(this.but_6);
            this.Controls.Add(this.but_5);
            this.Controls.Add(this.but_4);
            this.Controls.Add(this.but_inv);
            this.Controls.Add(this.but_div);
            this.Controls.Add(this.but_9);
            this.Controls.Add(this.but_8);
            this.Controls.Add(this.but_7);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.but_CE);
            this.Controls.Add(this.but_C);
            this.Controls.Add(this.tb);
            this.MaximizeBox = false;
            this.Name = "Calc";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button but_C;
        private System.Windows.Forms.Button but_CE;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button but_7;
        private System.Windows.Forms.Button but_8;
        private System.Windows.Forms.Button but_9;
        private System.Windows.Forms.Button but_div;
        private System.Windows.Forms.Button but_inv;
        private System.Windows.Forms.Button but_sqrt;
        private System.Windows.Forms.Button but_mult;
        private System.Windows.Forms.Button but_6;
        private System.Windows.Forms.Button but_5;
        private System.Windows.Forms.Button but_4;
        private System.Windows.Forms.Button but_pow;
        private System.Windows.Forms.Button but_min;
        private System.Windows.Forms.Button but_3;
        private System.Windows.Forms.Button but_2;
        private System.Windows.Forms.Button but_1;
        private System.Windows.Forms.Button but_eq;
        private System.Windows.Forms.Button but_plus;
        private System.Windows.Forms.Button but_dot;
        private System.Windows.Forms.Button but_0;
    }
}


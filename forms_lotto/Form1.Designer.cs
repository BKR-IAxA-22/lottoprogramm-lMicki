namespace forms_lotto
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateRandomNum = new System.Windows.Forms.Button();
            this.DisplayNum6 = new System.Windows.Forms.Label();
            this.DisplayNum5 = new System.Windows.Forms.Label();
            this.DisplayNum4 = new System.Windows.Forms.Label();
            this.DisplayNum1 = new System.Windows.Forms.Label();
            this.DisplayNum2 = new System.Windows.Forms.Label();
            this.DisplayNum3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateRandomNum
            // 
            this.GenerateRandomNum.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateRandomNum.Location = new System.Drawing.Point(13, 12);
            this.GenerateRandomNum.Name = "GenerateRandomNum";
            this.GenerateRandomNum.Size = new System.Drawing.Size(192, 57);
            this.GenerateRandomNum.TabIndex = 0;
            this.GenerateRandomNum.Text = "Generate!";
            this.GenerateRandomNum.UseVisualStyleBackColor = true;
            this.GenerateRandomNum.Click += new System.EventHandler(this.GenerateRandomNum_Click);
            // 
            // DisplayNum6
            // 
            this.DisplayNum6.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayNum6.Location = new System.Drawing.Point(144, 157);
            this.DisplayNum6.Name = "DisplayNum6";
            this.DisplayNum6.Size = new System.Drawing.Size(61, 53);
            this.DisplayNum6.TabIndex = 6;
            this.DisplayNum6.Text = "25";
            this.DisplayNum6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayNum5
            // 
            this.DisplayNum5.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayNum5.Location = new System.Drawing.Point(79, 157);
            this.DisplayNum5.Name = "DisplayNum5";
            this.DisplayNum5.Size = new System.Drawing.Size(61, 53);
            this.DisplayNum5.TabIndex = 7;
            this.DisplayNum5.Text = "25";
            this.DisplayNum5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayNum4
            // 
            this.DisplayNum4.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayNum4.Location = new System.Drawing.Point(12, 157);
            this.DisplayNum4.Name = "DisplayNum4";
            this.DisplayNum4.Size = new System.Drawing.Size(61, 53);
            this.DisplayNum4.TabIndex = 8;
            this.DisplayNum4.Text = "25";
            this.DisplayNum4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayNum1
            // 
            this.DisplayNum1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayNum1.Location = new System.Drawing.Point(12, 94);
            this.DisplayNum1.Name = "DisplayNum1";
            this.DisplayNum1.Size = new System.Drawing.Size(61, 53);
            this.DisplayNum1.TabIndex = 9;
            this.DisplayNum1.Text = "25";
            this.DisplayNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayNum2
            // 
            this.DisplayNum2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayNum2.Location = new System.Drawing.Point(79, 94);
            this.DisplayNum2.Name = "DisplayNum2";
            this.DisplayNum2.Size = new System.Drawing.Size(61, 53);
            this.DisplayNum2.TabIndex = 10;
            this.DisplayNum2.Text = "25";
            this.DisplayNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayNum3
            // 
            this.DisplayNum3.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayNum3.Location = new System.Drawing.Point(144, 94);
            this.DisplayNum3.Name = "DisplayNum3";
            this.DisplayNum3.Size = new System.Drawing.Size(61, 53);
            this.DisplayNum3.TabIndex = 11;
            this.DisplayNum3.Text = "25";
            this.DisplayNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 231);
            this.Controls.Add(this.DisplayNum3);
            this.Controls.Add(this.DisplayNum2);
            this.Controls.Add(this.DisplayNum1);
            this.Controls.Add(this.DisplayNum4);
            this.Controls.Add(this.DisplayNum5);
            this.Controls.Add(this.DisplayNum6);
            this.Controls.Add(this.GenerateRandomNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerateRandomNum;
        private System.Windows.Forms.Label DisplayNum6;
        private System.Windows.Forms.Label DisplayNum5;
        private System.Windows.Forms.Label DisplayNum4;
        private System.Windows.Forms.Label DisplayNum1;
        private System.Windows.Forms.Label DisplayNum2;
        private System.Windows.Forms.Label DisplayNum3;
    }
}


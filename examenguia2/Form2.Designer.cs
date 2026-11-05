namespace examenguia2
{
    partial class Form2
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
            this.TextNum1 = new System.Windows.Forms.TextBox();
            this.TextNum2 = new System.Windows.Forms.TextBox();
            this.BtnSumar = new System.Windows.Forms.Button();
            this.BtnResta = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextNum1
            // 
            this.TextNum1.BackColor = System.Drawing.Color.Fuchsia;
            this.TextNum1.Location = new System.Drawing.Point(293, 76);
            this.TextNum1.Name = "TextNum1";
            this.TextNum1.Size = new System.Drawing.Size(60, 22);
            this.TextNum1.TabIndex = 0;
            // 
            // TextNum2
            // 
            this.TextNum2.BackColor = System.Drawing.Color.Blue;
            this.TextNum2.Location = new System.Drawing.Point(510, 76);
            this.TextNum2.Name = "TextNum2";
            this.TextNum2.Size = new System.Drawing.Size(65, 22);
            this.TextNum2.TabIndex = 1;
            // 
            // BtnSumar
            // 
            this.BtnSumar.BackColor = System.Drawing.Color.Yellow;
            this.BtnSumar.Location = new System.Drawing.Point(401, 130);
            this.BtnSumar.Name = "BtnSumar";
            this.BtnSumar.Size = new System.Drawing.Size(70, 30);
            this.BtnSumar.TabIndex = 2;
            this.BtnSumar.Text = "Sumar";
            this.BtnSumar.UseVisualStyleBackColor = false;
            this.BtnSumar.Click += new System.EventHandler(this.BtnSumar_Click);
            // 
            // BtnResta
            // 
            this.BtnResta.BackColor = System.Drawing.Color.Red;
            this.BtnResta.Location = new System.Drawing.Point(551, 130);
            this.BtnResta.Name = "BtnResta";
            this.BtnResta.Size = new System.Drawing.Size(69, 34);
            this.BtnResta.TabIndex = 3;
            this.BtnResta.Text = "Restar";
            this.BtnResta.UseVisualStyleBackColor = false;
            this.BtnResta.Click += new System.EventHandler(this.BtnResta_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.BackColor = System.Drawing.Color.Lime;
            this.BtnDiv.Location = new System.Drawing.Point(210, 143);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(96, 21);
            this.BtnDiv.TabIndex = 4;
            this.BtnDiv.Text = "Dividir";
            this.BtnDiv.UseVisualStyleBackColor = false;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label1.Location = new System.Drawing.Point(348, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 16);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Calculadora";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnResta);
            this.Controls.Add(this.BtnSumar);
            this.Controls.Add(this.TextNum2);
            this.Controls.Add(this.TextNum1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextNum1;
        private System.Windows.Forms.TextBox TextNum2;
        private System.Windows.Forms.Button BtnSumar;
        private System.Windows.Forms.Button BtnResta;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Label Label1;
    }
}
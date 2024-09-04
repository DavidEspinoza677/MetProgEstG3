namespace EvalueAge
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
            this.tbAge = new System.Windows.Forms.TextBox();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce tu Edad: ";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(163, 58);
            this.tbAge.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(198, 20);
            this.tbAge.TabIndex = 1;
            this.tbAge.TextChanged += new System.EventHandler(this.tbAge_TextChanged);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(384, 58);
            this.btnEvaluate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(111, 24);
            this.btnEvaluate.TabIndex = 2;
            this.btnEvaluate.Text = "Evaluar";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAnswer.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAnswer.Location = new System.Drawing.Point(16, 114);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(479, 151);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswer.Click += new System.EventHandler(this.lblAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 311);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluar Edad ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Label lblAnswer;
    }
}


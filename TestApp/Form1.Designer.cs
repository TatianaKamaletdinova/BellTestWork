﻿namespace TestApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.textArrayOrigin = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textIteration = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Начать!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.generation_Array);
            // 
            // textArrayOrigin
            // 
            this.textArrayOrigin.AutoSize = true;
            this.textArrayOrigin.Location = new System.Drawing.Point(300, 27);
            this.textArrayOrigin.Name = "textArrayOrigin";
            this.textArrayOrigin.Size = new System.Drawing.Size(0, 13);
            this.textArrayOrigin.TabIndex = 1;
            // 
            // textResult
            // 
            this.textResult.AutoSize = true;
            this.textResult.ForeColor = System.Drawing.Color.Blue;
            this.textResult.Location = new System.Drawing.Point(105, 97);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(0, 13);
            this.textResult.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Итерации:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Результат:";
            // 
            // textIteration
            // 
            this.textIteration.AutoSize = true;
            this.textIteration.Location = new System.Drawing.Point(300, 59);
            this.textIteration.Name = "textIteration";
            this.textIteration.Size = new System.Drawing.Size(0, 13);
            this.textIteration.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(192, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Исходный массив:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(430, 181);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textIteration);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textArrayOrigin);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировка массива";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label textArrayOrigin;
        private System.Windows.Forms.Label textResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label textIteration;
        private System.Windows.Forms.Label label9;
    }
}


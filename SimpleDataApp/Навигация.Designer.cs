﻿namespace SimpleDataApp
{
    partial class Навигация
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите действие";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 62);
            this.button1.Name = "btnGoToAdd";
            this.button1.Size = new System.Drawing.Size(137, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить учётную запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnGoToAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 108);
            this.button2.Name = "btnGoToFillOrCancel";
            this.button2.Size = new System.Drawing.Size(137, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Заполнить или отменить заказ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnGoToFillOrCancel_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 173);
            this.button3.Name = "btnExit";
            this.button3.Size = new System.Drawing.Size(137, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Выйти";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Навигация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 208);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Навигация";
            this.Text = "Навигация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


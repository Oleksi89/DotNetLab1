namespace WinFormsApp1
{
    partial class UserControlTransfer
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxCardNum = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxSumWith = new TextBox();
            buttonTransfer = new Button();
            buttonBack = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // textBoxCardNum
            // 
            textBoxCardNum.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCardNum.Location = new Point(249, 168);
            textBoxCardNum.Name = "textBoxCardNum";
            textBoxCardNum.Size = new Size(428, 33);
            textBoxCardNum.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(237, 135);
            label2.Name = "label2";
            label2.Size = new Size(347, 30);
            label2.TabIndex = 3;
            label2.Text = "Введіть номер картки отримувача:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(237, 236);
            label1.Name = "label1";
            label1.Size = new Size(139, 30);
            label1.TabIndex = 18;
            label1.Text = "Введіть суму:";
            // 
            // textBoxSumWith
            // 
            textBoxSumWith.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSumWith.Location = new Point(237, 285);
            textBoxSumWith.Name = "textBoxSumWith";
            textBoxSumWith.Size = new Size(428, 33);
            textBoxSumWith.TabIndex = 17;
            // 
            // buttonTransfer
            // 
            buttonTransfer.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTransfer.Location = new Point(351, 408);
            buttonTransfer.Name = "buttonTransfer";
            buttonTransfer.Size = new Size(238, 45);
            buttonTransfer.TabIndex = 21;
            buttonTransfer.Text = "Переказати";
            buttonTransfer.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.Location = new Point(523, 519);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(238, 45);
            buttonBack.TabIndex = 20;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(174, 519);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(238, 45);
            buttonExit.TabIndex = 19;
            buttonExit.Text = "Вихід";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // UserControlTransfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonTransfer);
            Controls.Add(buttonBack);
            Controls.Add(buttonExit);
            Controls.Add(label1);
            Controls.Add(textBoxSumWith);
            Controls.Add(textBoxCardNum);
            Controls.Add(label2);
            Name = "UserControlTransfer";
            Size = new Size(1019, 633);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBoxCardNum;
        private Label label2;
        private Label label1;
        public TextBox textBoxSumWith;
        public Button buttonTransfer;
        public Button buttonBack;
        public Button buttonExit;
    }
}

namespace WinFormsApp1
{
    partial class UserControlWithdraw
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
            label2 = new Label();
            textBoxSumWith = new TextBox();
            buttonWithDraw = new Button();
            buttonBack = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(232, 206);
            label2.Name = "label2";
            label2.Size = new Size(139, 30);
            label2.TabIndex = 16;
            label2.Text = "Введіть суму:";
            // 
            // textBoxSumWith
            // 
            textBoxSumWith.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSumWith.Location = new Point(232, 255);
            textBoxSumWith.Name = "textBoxSumWith";
            textBoxSumWith.Size = new Size(428, 33);
            textBoxSumWith.TabIndex = 15;
            // 
            // buttonWithDraw
            // 
            buttonWithDraw.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWithDraw.Location = new Point(316, 365);
            buttonWithDraw.Name = "buttonWithDraw";
            buttonWithDraw.Size = new Size(238, 45);
            buttonWithDraw.TabIndex = 14;
            buttonWithDraw.Text = "Зняти кошти";
            buttonWithDraw.UseVisualStyleBackColor = true;
            buttonWithDraw.Click += buttonWithDraw_Click;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.Location = new Point(484, 505);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(238, 45);
            buttonBack.TabIndex = 13;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(135, 505);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(238, 45);
            buttonExit.TabIndex = 12;
            buttonExit.Text = "Вихід";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // UserControlWithdraw
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(textBoxSumWith);
            Controls.Add(buttonWithDraw);
            Controls.Add(buttonBack);
            Controls.Add(buttonExit);
            Name = "UserControlWithdraw";
            Size = new Size(907, 624);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        public TextBox textBoxSumWith;
        public Button buttonWithDraw;
        public Button buttonBack;
        public Button buttonExit;
    }
}

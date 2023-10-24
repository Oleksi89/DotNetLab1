namespace WinFormsApp1
{
    partial class UserControlDeposit
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
            buttonBack = new Button();
            buttonExit = new Button();
            buttonDeposit = new Button();
            textBoxCardNum = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.Location = new Point(459, 551);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(238, 45);
            buttonBack.TabIndex = 8;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(110, 551);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(238, 45);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Вихід";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonDeposit
            // 
            buttonDeposit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDeposit.Location = new Point(289, 394);
            buttonDeposit.Name = "buttonDeposit";
            buttonDeposit.Size = new Size(238, 45);
            buttonDeposit.TabIndex = 9;
            buttonDeposit.Text = "Поповнити баланс";
            buttonDeposit.UseVisualStyleBackColor = true;
            // 
            // textBoxCardNum
            // 
            textBoxCardNum.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCardNum.Location = new Point(207, 301);
            textBoxCardNum.Name = "textBoxCardNum";
            textBoxCardNum.Size = new Size(428, 33);
            textBoxCardNum.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(207, 252);
            label2.Name = "label2";
            label2.Size = new Size(139, 30);
            label2.TabIndex = 11;
            label2.Text = "Введіть суму:";
            // 
            // UserControlDeposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(textBoxCardNum);
            Controls.Add(buttonDeposit);
            Controls.Add(buttonBack);
            Controls.Add(buttonExit);
            Name = "UserControlDeposit";
            Size = new Size(858, 642);
            Load += UserControlDeposit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button buttonBack;
        public Button buttonExit;
        public Button buttonDeposit;
        public TextBox textBoxCardNum;
        private Label label2;
    }
}

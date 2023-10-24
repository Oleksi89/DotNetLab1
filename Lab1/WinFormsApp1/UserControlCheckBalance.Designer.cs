namespace WinFormsApp1
{
    partial class UserControlCheckBalance
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
            buttonCheckBalance = new Button();
            label1 = new Label();
            labelCardNumber = new Label();
            buttonBack = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // buttonCheckBalance
            // 
            buttonCheckBalance.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCheckBalance.Location = new Point(267, 326);
            buttonCheckBalance.Name = "buttonCheckBalance";
            buttonCheckBalance.Size = new Size(244, 40);
            buttonCheckBalance.TabIndex = 0;
            buttonCheckBalance.Text = "перевірити баланс";
            buttonCheckBalance.UseVisualStyleBackColor = true;
            buttonCheckBalance.Click += buttonCheckBalance_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(232, 133);
            label1.Name = "label1";
            label1.Size = new Size(83, 30);
            label1.TabIndex = 1;
            label1.Text = "Картка:";
            label1.Click += label1_Click;
            // 
            // labelCardNumber
            // 
            labelCardNumber.AutoSize = true;
            labelCardNumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelCardNumber.Location = new Point(321, 133);
            labelCardNumber.Name = "labelCardNumber";
            labelCardNumber.Size = new Size(37, 30);
            labelCardNumber.TabIndex = 2;
            labelCardNumber.Text = "---";
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.Location = new Point(454, 448);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(238, 45);
            buttonBack.TabIndex = 8;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(105, 448);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(238, 45);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Вихід";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // UserControlCheckBalance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonBack);
            Controls.Add(buttonExit);
            Controls.Add(labelCardNumber);
            Controls.Add(label1);
            Controls.Add(buttonCheckBalance);
            Name = "UserControlCheckBalance";
            Size = new Size(839, 556);
            Load += UserControlCheckBalance_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button buttonCheckBalance;
        private Label label1;
        public Label labelCardNumber;
        public Button buttonBack;
        public Button buttonExit;
    }
}

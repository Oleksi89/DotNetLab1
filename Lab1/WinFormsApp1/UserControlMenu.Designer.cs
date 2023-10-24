namespace WinFormsApp1
{
    partial class UserControlMenu
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
            label1 = new Label();
            buttonDeposit = new Button();
            buttonWithDraw = new Button();
            buttonTransfer = new Button();
            buttonCheckBalance = new Button();
            buttonExit = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(270, 91);
            label1.Name = "label1";
            label1.Size = new Size(308, 32);
            label1.TabIndex = 0;
            label1.Text = "Виберіть потрібну послугу";
            // 
            // buttonDeposit
            // 
            buttonDeposit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDeposit.Location = new Point(123, 185);
            buttonDeposit.Name = "buttonDeposit";
            buttonDeposit.Size = new Size(238, 45);
            buttonDeposit.TabIndex = 1;
            buttonDeposit.Text = "Поповнити баланс";
            buttonDeposit.UseVisualStyleBackColor = true;
            buttonDeposit.Click += button1_Click;
            // 
            // buttonWithDraw
            // 
            buttonWithDraw.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWithDraw.Location = new Point(123, 296);
            buttonWithDraw.Name = "buttonWithDraw";
            buttonWithDraw.Size = new Size(238, 45);
            buttonWithDraw.TabIndex = 2;
            buttonWithDraw.Text = "Зняти кошти";
            buttonWithDraw.UseVisualStyleBackColor = true;
            // 
            // buttonTransfer
            // 
            buttonTransfer.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTransfer.Location = new Point(472, 185);
            buttonTransfer.Name = "buttonTransfer";
            buttonTransfer.Size = new Size(238, 45);
            buttonTransfer.TabIndex = 3;
            buttonTransfer.Text = "Переказати кошти";
            buttonTransfer.UseVisualStyleBackColor = true;
            // 
            // buttonCheckBalance
            // 
            buttonCheckBalance.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCheckBalance.Location = new Point(472, 296);
            buttonCheckBalance.Name = "buttonCheckBalance";
            buttonCheckBalance.Size = new Size(238, 45);
            buttonCheckBalance.TabIndex = 4;
            buttonCheckBalance.Text = "Перевірити баланс";
            buttonCheckBalance.UseVisualStyleBackColor = true;
            buttonCheckBalance.Click += button4_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(123, 515);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(238, 45);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Вихід";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.Location = new Point(472, 515);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(238, 45);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // UserControlMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonBack);
            Controls.Add(buttonExit);
            Controls.Add(buttonCheckBalance);
            Controls.Add(buttonTransfer);
            Controls.Add(buttonWithDraw);
            Controls.Add(buttonDeposit);
            Controls.Add(label1);
            Name = "UserControlMenu";
            Size = new Size(892, 593);
            Load += UserControlMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Button buttonDeposit;
        public Button buttonWithDraw;
        public Button buttonTransfer;
        public Button buttonCheckBalance;
        public Button buttonExit;
        public Button buttonBack;
    }
}

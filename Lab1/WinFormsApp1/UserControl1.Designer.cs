namespace WinFormsApp1
{
    partial class UserControl1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            textBoxCardNum = new TextBox();
            textBoxPass = new TextBox();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            buttonAprove = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(407, 71);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 0;
            label1.Text = "Авторизація";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(219, 176);
            label2.Name = "label2";
            label2.Size = new Size(226, 30);
            label2.TabIndex = 1;
            label2.Text = "Введіть номер картки:";
            // 
            // textBoxCardNum
            // 
            textBoxCardNum.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCardNum.Location = new Point(231, 209);
            textBoxCardNum.Name = "textBoxCardNum";
            textBoxCardNum.Size = new Size(428, 33);
            textBoxCardNum.TabIndex = 2;
            // 
            // textBoxPass
            // 
            textBoxPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPass.Location = new Point(231, 332);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '*';
            textBoxPass.Size = new Size(428, 33);
            textBoxPass.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(219, 299);
            label3.Name = "label3";
            label3.Size = new Size(90, 30);
            label3.TabIndex = 3;
            label3.Text = "Пароль:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // buttonAprove
            // 
            buttonAprove.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAprove.Location = new Point(399, 411);
            buttonAprove.Name = "buttonAprove";
            buttonAprove.Size = new Size(190, 41);
            buttonAprove.TabIndex = 6;
            buttonAprove.Text = "Підтвердити";
            buttonAprove.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(374, 502);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(238, 45);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Вихід";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonExit);
            Controls.Add(buttonAprove);
            Controls.Add(textBoxPass);
            Controls.Add(label3);
            Controls.Add(textBoxCardNum);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(1050, 571);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public TextBox textBoxCardNum;
        public TextBox textBoxPass;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
        public Button buttonAprove;
        public Button buttonExit;
    }
}

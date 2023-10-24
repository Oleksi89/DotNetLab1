using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Security.Principal;
using BankSimulation;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        UserControl1 UserControlAuthorization = new UserControl1();
        UserControlMenu UserControlMenu = new UserControlMenu();
        UserControlDeposit UserControlDeposit = new UserControlDeposit();
        UserControlWithdraw UserControlWithdraw = new UserControlWithdraw();
        UserControlTransfer UserControlTransfer = new UserControlTransfer();
        UserControlCheckBalance UserControlCheckBalance = new UserControlCheckBalance();

        Bank bank = new Bank("MyBank");
       private Account account;
        public Form1()
        {
            InitializeComponent();



            this.Controls.Add(UserControlAuthorization);
            bank.CreateAccount(123456, "User1", 1100, 1111);
            bank.CreateAccount(789012, "User2", 12000, 2222);

            var atm1 = new AutomatedTellerMachine("ATM1", 10000);
            var atm2 = new AutomatedTellerMachine("ATM2", 15000);

            bank.AddATM(atm1);
            bank.AddATM(atm2);
            bank.SetFixedATM(atm1);

            bank.LogEvent += LogToConsole;

            // Додавання облікових записів


            // Обробник події натискання кнопки "Підтвердити" на формі авторизації
            // Обробник події натискання кнопки "Підтвердити" на формі авторизації
            UserControlAuthorization.buttonAprove.Click += (s, e) =>
            {
                if (int.TryParse(UserControlAuthorization.textBoxCardNum.Text, out int cardNumber))
                {
                    if (decimal.TryParse(UserControlAuthorization.textBoxPass.Text, out decimal pin))
                    {
                        // Автентифікація
                        account = bank.Authenticate(cardNumber, pin);
                        if (account != null)
                        {
                            // Якщо автентифікація успішна, перехід до меню
                            this.Controls.Clear();
                            this.Controls.Add(UserControlMenu);
                        }
                        else
                        {
                            LogToConsole("Невірний номер картки або пін-код.");
                        }
                    }
                    else
                    {
                        LogToConsole("Невірний формат пін-коду.");
                    }
                }
                else
                {
                    LogToConsole("Невірний формат номеру картки.");
                }
            };

            // Обробники подій для кнопок меню
            UserControlMenu.buttonDeposit.Click += (s, e) =>
            {
                this.Controls.Clear();
                this.Controls.Add(UserControlDeposit);
            };
            UserControlMenu.buttonWithDraw.Click += (s, e) =>
            {
                this.Controls.Clear();
                this.Controls.Add(UserControlWithdraw);
            };
            UserControlMenu.buttonTransfer.Click += (s, e) =>
            {
                this.Controls.Clear();
                this.Controls.Add(UserControlTransfer);
            };
            UserControlMenu.buttonCheckBalance.Click += (s, e) =>
            {
                // Виведення номера картки з заміною всіх, крім останніх 4 цифр, на зірочки
                string cardNumber = account.CardNumber.ToString();
                string cardNumberStars = cardNumber.Length > 4
                    ? new string('*', cardNumber.Length - 4) + cardNumber.Substring(cardNumber.Length - 4)
                    : cardNumber;
                UserControlCheckBalance.labelCardNumber.Text = cardNumberStars;

                this.Controls.Clear();
                this.Controls.Add(UserControlCheckBalance);
            };

            // Обробник події для кнопки "Назад" в меню
            UserControlMenu.buttonBack.Click += (s, e) =>
            {
                this.Controls.Clear();
                this.Controls.Add(UserControlAuthorization);
            };

            // Обробники подій для кнопок "Назад"
            UserControlDeposit.buttonBack.Click += (s, e) =>
            {
                this.Controls.Clear();
                this.Controls.Add(UserControlMenu);
            };
            UserControlWithdraw.buttonBack.Click += (s, e) =>
            {
                this.Controls.Clear();
                this.Controls.Add(UserControlMenu);
            };
            UserControlTransfer.buttonBack.Click += (s, e) =>
            {
                this.Controls.Clear();
                this.Controls.Add(UserControlMenu);
            };
            UserControlCheckBalance.buttonBack.Click += (s, e) =>
            {
                this.Controls.Clear();
                this.Controls.Add(UserControlMenu);
            };

            // Обробники подій для кнопок "Вийти"
            UserControlAuthorization.buttonExit.Click += (s, e) => { Application.Exit(); };
            UserControlMenu.buttonExit.Click += (s, e) => { Application.Exit(); };
            UserControlDeposit.buttonExit.Click += (s, e) => { Application.Exit(); };
            UserControlWithdraw.buttonExit.Click += (s, e) => { Application.Exit(); };
            UserControlTransfer.buttonExit.Click += (s, e) => { Application.Exit(); };
            UserControlCheckBalance.buttonExit.Click += (s, e) => { Application.Exit(); };

            // Обробники подій для кнопок "Поповнити", "Зняти", "Переказати"
            UserControlDeposit.buttonDeposit.Click += (s, e) =>
            {
                if (decimal.TryParse(UserControlDeposit.textBoxCardNum.Text, out decimal depositAmount))
                {
                    bank.DepositFunds(account, depositAmount);
                }
                else
                {
                    LogToConsole("Невірний формат суми.");
                }
            };
            UserControlWithdraw.buttonWithDraw.Click += (s, e) =>
            {
                if (decimal.TryParse(UserControlWithdraw.textBoxSumWith.Text, out decimal withdrawalAmount))
                {
                    bank.WithdrawFunds(account, withdrawalAmount);
                }
                else
                {
                    LogToConsole("Невірний формат суми.");
                }
            };
            UserControlTransfer.buttonTransfer.Click += (s, e) =>
            {
                if (int.TryParse(UserControlTransfer.textBoxCardNum.Text, out int targetCardNumber))
                {
                    Account targetAccount = bank.Accounts.FirstOrDefault(acc => acc.CardNumber == targetCardNumber);
                    if (targetAccount != null)
                    {
                        if (decimal.TryParse(UserControlTransfer.textBoxSumWith.Text, out decimal transferAmount))
                        {
                            bank.TransferFunds(account, targetAccount, transferAmount);
                        }
                        else
                        {
                            LogToConsole("Невірний формат суми.");
                        }
                    }
                    else
                    {
                        LogToConsole("Обліковий запис отримувача не знайдено.");
                    }
                }
                else
                {
                    LogToConsole("Невірний формат номеру картки.");
                }
            };

            // Обробник події для кнопки "Перевірити баланс"
            UserControlCheckBalance.buttonCheckBalance.Click += (s, e) =>
            {
                bank.ShowAccountBalance(account);

            };



            static void LogToConsole(string message)
            {
                MessageBox.Show(message);
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            



        }

        

    }
}
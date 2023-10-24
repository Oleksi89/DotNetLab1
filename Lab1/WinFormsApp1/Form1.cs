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

            // ��������� �������� ������


            // �������� ��䳿 ���������� ������ "ϳ���������" �� ���� �����������
            // �������� ��䳿 ���������� ������ "ϳ���������" �� ���� �����������
            UserControlAuthorization.buttonAprove.Click += (s, e) =>
            {
                if (int.TryParse(UserControlAuthorization.textBoxCardNum.Text, out int cardNumber))
                {
                    if (decimal.TryParse(UserControlAuthorization.textBoxPass.Text, out decimal pin))
                    {
                        // ��������������
                        account = bank.Authenticate(cardNumber, pin);
                        if (account != null)
                        {
                            // ���� �������������� ������, ������� �� ����
                            this.Controls.Clear();
                            this.Controls.Add(UserControlMenu);
                        }
                        else
                        {
                            LogToConsole("������� ����� ������ ��� ��-���.");
                        }
                    }
                    else
                    {
                        LogToConsole("������� ������ ��-����.");
                    }
                }
                else
                {
                    LogToConsole("������� ������ ������ ������.");
                }
            };

            // ��������� ���� ��� ������ ����
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
                // ��������� ������ ������ � ������ ���, ��� ������� 4 ����, �� ������
                string cardNumber = account.CardNumber.ToString();
                string cardNumberStars = cardNumber.Length > 4
                    ? new string('*', cardNumber.Length - 4) + cardNumber.Substring(cardNumber.Length - 4)
                    : cardNumber;
                UserControlCheckBalance.labelCardNumber.Text = cardNumberStars;

                this.Controls.Clear();
                this.Controls.Add(UserControlCheckBalance);
            };

            // �������� ��䳿 ��� ������ "�����" � ����
            UserControlMenu.buttonBack.Click += (s, e) =>
            {
                this.Controls.Clear();
                this.Controls.Add(UserControlAuthorization);
            };

            // ��������� ���� ��� ������ "�����"
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

            // ��������� ���� ��� ������ "�����"
            UserControlAuthorization.buttonExit.Click += (s, e) => { Application.Exit(); };
            UserControlMenu.buttonExit.Click += (s, e) => { Application.Exit(); };
            UserControlDeposit.buttonExit.Click += (s, e) => { Application.Exit(); };
            UserControlWithdraw.buttonExit.Click += (s, e) => { Application.Exit(); };
            UserControlTransfer.buttonExit.Click += (s, e) => { Application.Exit(); };
            UserControlCheckBalance.buttonExit.Click += (s, e) => { Application.Exit(); };

            // ��������� ���� ��� ������ "���������", "�����", "����������"
            UserControlDeposit.buttonDeposit.Click += (s, e) =>
            {
                if (decimal.TryParse(UserControlDeposit.textBoxCardNum.Text, out decimal depositAmount))
                {
                    bank.DepositFunds(account, depositAmount);
                }
                else
                {
                    LogToConsole("������� ������ ����.");
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
                    LogToConsole("������� ������ ����.");
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
                            LogToConsole("������� ������ ����.");
                        }
                    }
                    else
                    {
                        LogToConsole("�������� ����� ���������� �� ��������.");
                    }
                }
                else
                {
                    LogToConsole("������� ������ ������ ������.");
                }
            };

            // �������� ��䳿 ��� ������ "��������� ������"
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
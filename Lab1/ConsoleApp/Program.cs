using System;
using System.Collections.Generic;
using System.Linq;
using BankSimulation;

namespace BankSimulation
{
    

    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank("MyBank");

            // Створюємо облікові записи
            bank.CreateAccount(1234, "John Doe", 11000, 5678);
            bank.CreateAccount(5678, "Jane Smith", 1500, 4321);

            // Створюємо банкомати та додаємо обробники подій
            var atm1 = new AutomatedTellerMachine("ATM1", 10000);
            var atm2 = new AutomatedTellerMachine("ATM2", 15000);

            bank.AddATM(atm1);
            bank.AddATM(atm2);
            bank.SetFixedATM(atm1);
            bank.LogEvent += LogToConsole;

            while (true)
            {
                Console.WriteLine("Введіть номер картки:");
                if (int.TryParse(Console.ReadLine(), out int cardNumber))
                {
                    Console.WriteLine("Введіть пін-код:");
                    if (decimal.TryParse(Console.ReadLine(), out decimal pin))
                    {
                        Account account = bank.Authenticate(cardNumber, pin);
                        if (account != null)
                        {
                            LogToConsole($"Ласкаво просимо, {account.OwnerName}!");
                            ShowMenu(bank, account);
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
            }
        }

        static void ShowMenu(Bank bank, Account account)
        {
            while (true)
            {
                Console.WriteLine("Оберіть опцію:");
                Console.WriteLine("1. Перевірити баланс");
                Console.WriteLine("2. Зняти кошти");
                Console.WriteLine("3. Поповнити рахунок");
                Console.WriteLine("4. Переказати кошти");
                Console.WriteLine("5. Вийти");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            bank.ShowAccountBalance(account);
                            break;
                        case 2: // Зняти кошти
                            Console.WriteLine("Введіть суму для зняття:");
                            if (decimal.TryParse(Console.ReadLine(), out decimal withdrawalAmount))
                            {
                                bank.WithdrawFunds(account, withdrawalAmount);
                            }
                            else
                            {
                                Console.WriteLine("Невірний формат суми.");
                            }
                            break;
                        case 3: // Поповнити рахунок
                            Console.WriteLine("Введіть суму для поповнення:");
                            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                            {
                                bank.DepositFunds(account, depositAmount);
                            }
                            else
                            {
                                Console.WriteLine("Невірний формат суми.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Введіть номер картки отримувача:");
                            if (int.TryParse(Console.ReadLine(), out int targetCardNumber))
                            {
                                var targetAccount = bank.Accounts.FirstOrDefault(acc => acc.CardNumber == targetCardNumber);
                                if (targetAccount != null)
                                {
                                    Console.WriteLine("Введіть суму для переказу:");
                                    if (decimal.TryParse(Console.ReadLine(), out decimal transferAmount))
                                    {
                                        bank.TransferFunds(account, targetAccount, transferAmount);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Невірний формат суми.");
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
                            break;
                        case 5:
                            LogToConsole("Вихід з облікового запису.");
                            return;
                        default:
                            LogToConsole("Невірний вибір.");
                            break;
                    }
                }
                else
                {
                    LogToConsole("Невірний вибір.");
                }
            }
        }

        static void LogToConsole(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

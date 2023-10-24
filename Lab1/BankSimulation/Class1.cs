namespace BankSimulation
{

        public class Account
        {
            public int CardNumber { get; }
            public string OwnerName { get; }
            public decimal Balance { get; private set; }
            public decimal Pin { get; }

            public Account(int cardNumber, string ownerName, decimal initialBalance, decimal pin)
            {
                CardNumber = cardNumber;
                OwnerName = ownerName;
                Balance = initialBalance;
                Pin = pin;
            }

            public event Action<decimal> BalanceChanged;

            public void Withdraw(decimal amount)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                    BalanceChanged(Balance);
                }
            }

            public void Deposit(decimal amount)
            {
                Balance += amount;
                BalanceChanged(Balance);
            }

            public bool Authenticate(decimal pin)
            {
                return Pin == pin;
            }
        }

        public class AutomatedTellerMachine
        {
            public string ATMId { get; }
            public decimal AvailableFunds { get; private set; }
            public event Action<string, decimal> AvailableFundsChanged;

            public AutomatedTellerMachine(string atmId, decimal initialFunds)
            {
                ATMId = atmId;
                AvailableFunds = initialFunds;
            }

            public void Withdraw(decimal amount)
            {
                if (amount <= AvailableFunds)
                {
                    AvailableFunds -= amount;
                    AvailableFundsChanged(ATMId, AvailableFunds);
                }
            }

            public void Deposit(decimal amount)
            {
                AvailableFunds += amount;
                AvailableFundsChanged(ATMId, AvailableFunds);
            }
        }

        public class Bank
        {
            public string BankName { get; }
            public List<AutomatedTellerMachine> ATMs { get; } = new List<AutomatedTellerMachine>();
            public List<Account> Accounts { get; } = new List<Account>();
            private AutomatedTellerMachine fixedATM; // Фіксований банкомат для клієнта
            public event Action<string> LogEvent;

            public Bank(string bankName)
            {
                BankName = bankName;
            }

            public void AddATM(AutomatedTellerMachine atm)
            {
                ATMs.Add(atm);
                atm.AvailableFundsChanged += HandleATMAvailableFundsChanged;
            }

            public void CreateAccount(int cardNumber, string ownerName, decimal initialBalance, decimal pin)
            {
                var account = new Account(cardNumber, ownerName, initialBalance, pin);
                Accounts.Add(account);
                account.BalanceChanged += newBalance => LogEvent($"Зміна балансу для {account.OwnerName} (Номер картки: {account.CardNumber}): {newBalance} грн.");
                if (LogEvent != null)
                {
                    LogEvent($"Створено новий обліковий запис для {ownerName} (Номер картки: {cardNumber}).");
                }

            }

            public Account Authenticate(int cardNumber, decimal pin)
            {
                var account = Accounts.FirstOrDefault(acc => acc.CardNumber == cardNumber && acc.Pin == pin);
                if (account == null)
                {
                    LogEvent?.Invoke($"Невірний номер картки або пін-код для картки {cardNumber}.");
                }
                return account;
            }

            public void ShowAccountBalance(Account account)
            {
                LogEvent($"Баланс для {account.OwnerName} (Номер картки: {account.CardNumber}): {account.Balance} грн.");
            }

            public void SetFixedATM(AutomatedTellerMachine atm)
            {
                fixedATM = atm;
            }


            public void WithdrawFunds(Account account, decimal amount)
            {
                if (amount > 0)
                {
                    if (fixedATM != null)
                    {
                        if (fixedATM.AvailableFunds >= amount)
                        {
                            if (account.Balance >= amount)
                            {
                                account.Withdraw(amount);
                                fixedATM.Withdraw(amount);
                                LogEvent($"Знято {amount} грн з рахунку {account.OwnerName}. Новий баланс: {account.Balance} грн.");
                            }
                            else
                            {
                                LogEvent("Недостатньо коштів на рахунку.");
                            }
                        }
                        else
                        {
                            LogEvent($"Недостатньо коштів у банкоматі {fixedATM.ATMId}.");
                        }
                    }
                    else
                    {
                        LogEvent("Банкомат не вибраний.");
                    }
                }
                else
                {
                    LogEvent("Сума для зняття повинна бути більше нуля.");
                }
            }

            public void DepositFunds(Account account, decimal amount)
            {
                if (amount > 0)
                {
                    if (fixedATM != null)
                    {
                        account.Deposit(amount);
                        fixedATM.Deposit(amount);
                        LogEvent($"Поповнено {amount} грн на рахунок {account.OwnerName}. Новий баланс: {account.Balance} грн.");
                    }
                    else
                    {
                        LogEvent("Банкомат не вибраний.");
                    }
                }
                else
                {
                    LogEvent("Сума для поповнення повинна бути більше нуля.");
                }
            }

            public void TransferFunds(Account sourceAccount, Account targetAccount, decimal amount)
            {
                if (sourceAccount.Balance < amount)
                {
                    LogEvent("Недостатньо коштів для переказу.");
                }
                else
                {
                    sourceAccount.Withdraw(amount);
                    targetAccount.Deposit(amount);
                    LogEvent($"Переказано {amount} грн з рахунку {sourceAccount.OwnerName} на рахунок {targetAccount.OwnerName}.");
                }
            }

            public void HandleATMAvailableFundsChanged(string atmId, decimal newFunds)
            {
                LogEvent?.Invoke($"Зміна доступних коштів в банкоматі {atmId}. Новий баланс: {newFunds} грн.");
            }
        }
    }
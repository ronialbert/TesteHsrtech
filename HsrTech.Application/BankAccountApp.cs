﻿using HsrTech.Application.Interface;
using HsrTech.Domain.Entities;
using HsrTech.Domain.Entities.Partial;
using HsrTech.Domain.Interface.Service;
using System.Collections.Generic;

namespace HsrTech.Application
{
    public class BankAccountApp : AppBase<BankAccount>, IBankAccountApp
    {
        private readonly IBankAccountService _bankAccountService;
        public BankAccountApp(IBankAccountService bankAccount) : base(bankAccount)
        {
            _bankAccountService = bankAccount;
        }

        public Statistics GetStatisticsByLogin(string login, StatisticsOptions options)
        {
            return _bankAccountService.GetStatisticsByLogin(login, options);
        }

        public void CreateAccount(decimal balance, int limit, string name)
        {
            _bankAccountService.CreateAccount(balance, limit,name);
        }

        public BankAccount GetAccountByNumberAccount(int numberAccount)
        {
            return _bankAccountService.GetAccountByNumberAccount(numberAccount);
        }

        public IList<BankAccount> ListAccountsByLogin(string login)
        {
            return _bankAccountService.ListAccountsByLogin(login);
        }

        public bool Transfer(decimal value, int numberAccount, int typeTransfer, string login, int userNumberAccount)
        {
            return _bankAccountService.Transfer(value, numberAccount, typeTransfer, login, userNumberAccount);
        }
    }
}

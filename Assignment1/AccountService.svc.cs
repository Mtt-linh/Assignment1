using Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AccountService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AccountService.svc or AccountService.svc.cs at the Solution Explorer and start debugging.
    public class AccountService : IAccountService
    {
        Acc_DealContext db;
        public AccountService()
        {
            db = new Acc_DealContext();
        }
        public void AddAccount(Account account)
        {
            db.Accounts.Add(account);
            db.SaveChanges();
        }

        public void DeleteAccount(string id)
        {
            var ac = db.Accounts.Find(id);
            db.Accounts.Remove(ac);
            db.SaveChanges();
        }

        public void DoWork()
        {
            throw new NotImplementedException();
        }

        public Account GetAccountById(string accountNumber)
        {
            return db.Accounts.Where(x => x.AccountNumber == accountNumber).First();
        }

        public IEnumerable<Account> GetAccountList()
        {
            return db.Accounts.AsEnumerable();
        }

        public void UpdateAccount(Account ac)
        {
            db.Entry(ac).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}

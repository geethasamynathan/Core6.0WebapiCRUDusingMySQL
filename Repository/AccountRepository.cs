using System.Linq.Expressions;
using secondAPi.Models;
using secondAPi.Repository;
namespace secondAPi.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private RepositoryContext _context;

        public AccountRepository()
        {
        }

        public AccountRepository(RepositoryContext context)
        {
            _context=context;
        }
        public Account AddNewAccounts(Account account)
        {
           _context.Accounts.Add(account);
           _context.SaveChanges();
           return account;
        }

        // public Account AddNewUser(Account user)
        // {
        //     throw new NotImplementedException();
        // }

        // public void Create(Account entity)
        // {
        //     throw new NotImplementedException();
        // }

        // public void Delete(Account entity)
        // {
        //     throw new NotImplementedException();
        // }

        // public IQueryable<Account> FindAll()
        // {
        //     throw new NotImplementedException();
        // }

        // public IQueryable<Account> FindByCondition(Expression<Func<Account, bool>> expression)
        // {
        //     throw new NotImplementedException();
        // }

      

        public Account GetAccountById(int id)
        {
           return _context.Accounts.FirstOrDefault( a =>a.AccountId.Equals(id));
        }

        public List<Account> GetAllAccounts()
        {
          return _context.Accounts.ToList();
        }

        public void RemoveAccount(int id)
        {
           var accountInfo=_context.Accounts.FirstOrDefault(a =>a.AccountId.Equals(id));
           if(accountInfo!=null)
           {
            _context.Accounts.Remove(accountInfo);
            _context.SaveChanges();
           }
        }

        // public void Update(Account entity)
        // {
             
        // }

        public Account UpdateAccountinfo(Account entity)
        {
            var accountInfo=_context.Accounts.FirstOrDefault
             (a =>a.AccountId.Equals(entity.AccountId));
           if(accountInfo!=null)
           {
            accountInfo.AccountType=entity.AccountType;
            accountInfo.DateCreated=entity.DateCreated;
            accountInfo.OwnerId= entity.OwnerId;
            
           }
           _context.SaveChanges();
           return entity;
        }
    }
}
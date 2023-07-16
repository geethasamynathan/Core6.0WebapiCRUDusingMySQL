using secondAPi.Models;
namespace secondAPi.Repository
{
    public interface IAccountRepository //:IRepositoryBase<Account>
    {
          List<Account> GetAllAccounts();
        Account GetAccountById(int id);
        Account AddNewAccounts(Account user);
        Account UpdateAccountinfo(Account newuser);
        void RemoveAccount(int id);
    }
}
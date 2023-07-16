namespace secondAPi.Repository
{
    public interface IRepositoryWrapper
    {
        IOwnerRepository Owner{get;}
        IAccountRepository Account{get;}
        void Save();
    }
}
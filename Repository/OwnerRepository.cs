using secondAPi.Models;
using secondAPi.Repository;
namespace secondAPi.Repository
{
    public class OwnerRepository:IOwnerRepository

    {
        private RepositoryContext _context;
        public OwnerRepository(RepositoryContext repositoryContext)
        {
            _context=repositoryContext;
        }

        public Owner AddNewOwner(Owner owner)
        {
            _context.Owners.Add(owner);
           _context.SaveChanges();
           return owner;
        }

        public List<Owner> GetAllOwners()
        {
            return _context.Owners.ToList();
        }

        public Owner GetOwnerById(int id)
        {
             return _context.Owners.FirstOrDefault(o => o.OwnerId.Equals(id) );
        }

        public void RemoveOwner(int id)
        {
           Owner existingOwner= _context.Owners.FirstOrDefault(o => o.OwnerId.Equals(id));
           if(existingOwner!=null)
           {
            _context.Owners.Remove(existingOwner);
            _context.SaveChanges();
           }
        }

        public Owner UpdateOwnerinfo(Owner newowner)
        {
            var existingOwnerInfo=_context.Owners.FirstOrDefault
             (a =>a.OwnerId.Equals(newowner.OwnerId));
           if(existingOwnerInfo!=null)
           {
            existingOwnerInfo.Name =newowner.Name;
            existingOwnerInfo.DateOfBirth=newowner.DateOfBirth;
            existingOwnerInfo.Address= newowner.Address;
            existingOwnerInfo.Accounts=newowner.Accounts;
           }
           _context.SaveChanges();
           return newowner;
        }
    }
}
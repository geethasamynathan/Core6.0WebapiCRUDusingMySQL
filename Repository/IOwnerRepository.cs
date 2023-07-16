using secondAPi.Models;

namespace secondAPi.Repository
{
    public interface IOwnerRepository
    {
         List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
        Owner AddNewOwner(Owner owner);
        Owner UpdateOwnerinfo(Owner newowner);
        void RemoveOwner(int id);
         
    }
}
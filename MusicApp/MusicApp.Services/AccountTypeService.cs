using MusicApp.DataAccess;
using MusicApp.Domain.Models;

namespace MusicApp.Services
{
    public class AccountTypeService : IAccountTypeService
    {
        private IRepository<AccountType> _accountTypeRepository;
        public AccountTypeService(IRepository<AccountType> accountTypeRepository)
        {
            _accountTypeRepository = accountTypeRepository;
        }

        public int CreateNewAccount(AccountType entity)
        {
            return _accountTypeRepository.Insert(entity);
        }

        public void UpdateAccount(AccountType entity)
        {
            _accountTypeRepository.Update(entity);
        }

        public void DeleteAccountById(int id)
        {
            _accountTypeRepository.DeleteById(id);
        }
    }
}

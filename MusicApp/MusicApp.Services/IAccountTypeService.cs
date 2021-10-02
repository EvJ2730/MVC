using MusicApp.Domain.Models;

namespace MusicApp.Services
{
    public interface IAccountTypeService
    {
        public int CreateNewAccount(AccountType entity);
        public void UpdateAccount(AccountType entity);
        public void DeleteAccountById(int id);
    }
}

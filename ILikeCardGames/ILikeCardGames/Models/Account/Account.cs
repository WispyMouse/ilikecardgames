using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ILikeCardGames.Models.Account
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        public ICollection<AccountLoginInformation> AccountLoginInformations { get; set; }

        public AccountLoginInformation? GetLatestLoginInformation()
        {
            if (AccountLoginInformations == null || AccountLoginInformations.Count == 0)
            {
                return null;
            }

            return AccountLoginInformations.OrderBy(ali => ali.AccountId).Last();
        }
    }
}

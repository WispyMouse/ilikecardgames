using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ILikeCardGames.Models.Account
{ 
    [Table("AccountLoginInformations")]
    public class AccountLoginInformation
    {
        [Key]
        public int AccountLoginInformationId { get; set; }

        [ForeignKey(nameof(Account))]
        public int AccountId { get; set; }

        [Required]
        public string HashedAndSaltedPassword { get; set; }

        public Account Account { get; set; }
    }
}

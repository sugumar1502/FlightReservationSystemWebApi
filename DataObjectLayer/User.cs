using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjectLayer
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public int LoginStatus { get; set; }
        public string UserType { get; set; }

    }
    public class UserWallet
    {
        [Key]
        public int UserWalletId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set;}
        public string CreditCardNo { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public double Balance { get; set; }

        public double CurrentBalance { get; set; }

        public virtual User User { get; set; }


    }
    public class UserWalletTransaction
    {
        [Key]
        public int UserWalletTransactionId { get; set; }
        [ForeignKey("UserWallet")]
        public int UserWalletId { get; set; }
        public string Action { get; set; }
        public double Amount { get; set; }

        public virtual UserWallet UserWallet { get; set; }


    }



}

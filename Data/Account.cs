namespace WindowsFormsApp1.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public Account()
        {

        }
        public Account(string username, string displayname, string password, int type)
        {
            UserName = username;
            DisplayName = displayname;
            PassWord = password;
            TypeUser = type;
        }
        [Key]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string DisplayName { get; set; }

        [Required]
        [StringLength(1000)]
        public string PassWord { get; set; }

        public int TypeUser { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string FIO { get; set; }

        public string Filial { get; set; }

        public string Email { get; set; }
    }

    [Table("Equipment")]
    public class Equipment
    {
        [Key]
        public int Id { get; set; }

        public string personalNum { get; set; }

        public string name { get; set; }

        public string type { get; set; }

        public string invnum { get; set; }

        public string date { get; set; }

        public string price { get; set; }

        public string QR { get; set; }

        public string filial { get; set; }

        public string mol { get; set; }
    }
    [Table("Filial")]
    public class Filial
    {
        [Key]
        public int id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
    }
    [Table("History")]
    public class History
    {
        [Key]
        public int id { get; set; }

        public string Name { get; set; }

        public string InvNum { get; set; }

        public string mol { get; set; }

        public string mol1 { get; set; }

        public string Filial { get; set; }

        public string Date { get; set; }

        public string Status { get; set; }
    }
    [Table("Inventory")]
    public class Inventory
    {
        [Key]
        public int id { get; set; }

        public string mol { get; set; }

        public string Filial { get; set; }

        public string Equipment { get; set; }
    }

    [Table("Profile")]
    public class Profile
    {
        [Key]
        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Patronymic { get; set; }

        public string Branch { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public byte[] ImageData { get; set; }
    }
    
}

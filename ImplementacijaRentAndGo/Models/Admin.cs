using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementacijaRentAndGo.Models
{
    public class Admin
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Lozinka { get; set; }

        public Admin() { }
        public Admin(string noviUserName, string novaLozinka)
        {
            ID = GenerišiID();
            Username = noviUserName;
            Lozinka = novaLozinka;
        }

        public int GenerišiID()
        {
            int id = 0;
            Random generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                id += (int)Math.Pow(10, i) * generator.Next(0, 9);
            }
            return id;
        }
    }
}

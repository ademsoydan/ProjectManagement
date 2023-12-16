using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string TelefonNumarasi { get; set; }
        public string Adres { get; set; }

        public string Password { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Fotograf { get; set; }
        
        public Employee(int id, string firstName, string lastName, string email, string phoneNumber, string address, DateTime dogumTarihi, string fotograf, string password)
        {
            Id = id;
            Ad = firstName;
            Soyad = lastName;
            Email = email;
            TelefonNumarasi = phoneNumber;
            Adres = address;
            DogumTarihi = dogumTarihi;
            Fotograf = fotograf;
            Password = password;
        }
        public Employee() { }
    }
}

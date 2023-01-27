using System;
using System.ComponentModel.DataAnnotations;

namespace InternalErpProject.WebAPI.Models
{
    public class PersonModel
    {
        public PersonModel() { }
        public PersonModel(int idPerson, string name, int rg, int cpf, DateTime birthDate, int nitPisNit, string email, int telephone, string state, string city, bool hired, string emergencyContactName, int emergencyContact)
        {
            this.IdPerson = idPerson;
            this.Name = name;
            this.Rg = rg;
            this.Cpf = cpf;
            this.BirthDate = birthDate;
            this.NitPisNit = nitPisNit;
            this.Email = email;
            this.Telephone = telephone;
            this.State = state;
            this.City = city;
            this.Hired = hired;
            this.EmergencyContactName = emergencyContactName;
            this.EmergencyContact = emergencyContact;
        }

        [Key]
        public int IdPerson { get; set; }
        public string Name { get; set; }
        public int Rg { get; set; }
        public int Cpf { get; set; }
        public DateTime BirthDate { get; set; }
        public int NitPisNit { get; set; }
        public string Email { get; set; }
        public int Telephone { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public bool Hired { get; set; }
        public string EmergencyContactName { get; set; }
        public int EmergencyContact { get;set; }
    }
}

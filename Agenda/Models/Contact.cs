using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Models
{
    class Contact
    {
        private int id;
        private string nom;
        private string prenom;
        private string telephone;
        private string mail;
        [Key]
        public int Id { get => id; set => id = value; }
        [StringLength(50)]
        public string Nom { get => nom; set => nom = value; }
        [StringLength(50)]
        public string Prenom { get => prenom; set => prenom = value; }
        [StringLength(13)]
        public string Telephone { get => telephone; set => telephone = value; }
        [StringLength(50)]
        public string Mail { get => mail; set => mail = value; }
    }
}

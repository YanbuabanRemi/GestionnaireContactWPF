using Agenda.Models;
using Agenda.Tools;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Agenda.ViewsModels
{
    class AjouterContactViewModel : ViewModelBase
    {
        public Contact contact { get; set; }

        public ICommand ajouterContacVM { get; set; }

        public string Nom
        {
            get => contact.Nom;
            set
            {
                contact.Nom = value;
                RaisePropertyChanged();
            }
        }

        public string Prenom
        {
            get => contact.Prenom;
            set
            {
                contact.Prenom = value;
                RaisePropertyChanged();
            }
        }

        public string Telephone
        {
            get => contact.Telephone;
            set
            {
                contact.Telephone = value;
                RaisePropertyChanged();
            }
        }

        public string Email
        {
            get => contact.Mail;
            set
            {
                contact.Mail = value;
                RaisePropertyChanged();
            }
        }

        public AjouterContactViewModel()
        {
            contact = new Contact();
            ajouterContacVM = new RelayCommand(ajouter);
        }

        public void ajouter()
        {
            DataContext.Instance.contact.Add(contact);
            DataContext.Instance.SaveChanges();
        }
    }
}

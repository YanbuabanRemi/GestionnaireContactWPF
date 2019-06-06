using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Agenda.ViewsModels
{
    class MainWindowViewModel : ViewModelBase
    {
        public ICommand ajouterContactCommand { get; set; }
        public ICommand modifierContactCommand { get; set; }
        public ICommand supprimerContactCommand { get; set; }
        public ICommand listeContactCommand { get; set; }

        public Grid maGrille { get; set; }

        public MainWindowViewModel(Grid g)
        {
            maGrille = g;
            ajouterContactCommand = new RelayCommand(AjouterContact);
            modifierContactCommand = new RelayCommand(ModifierContact);
            supprimerContactCommand = new RelayCommand(SupprimerContact);
            listeContactCommand = new RelayCommand(ListeContact);
        }

        public void AjouterContact()
        {
            Clear();
            maGrille.DataContext = new AjouterContactViewModel();
            GenerateRowColumn(maGrille, 5, 2);
            //On génére les labels
            string[] mesLabels = new string[] { "Nom", "Prénom", "Tel", "Emails" };
            for (int i = 0; i < mesLabels.Length; i++)
            {
                Label l = new Label()
                {
                    Content = mesLabels[i]
                };
                maGrille.Children.Add(l);
                Grid.SetColumn(l, 0);
                Grid.SetRow(l, i);
            }
            // On génére les Textbox qui doit bien prendre en compte le nom exact du AjouterContactViewModel
            string[] mesTextBox = new string[] { "Nom", "Prenom", "Telephone", "Email" };
            for (int i = 0; i < mesTextBox.Length; i++)
            {
                TextBox t = new TextBox();
                t.SetBinding(TextBox.TextProperty, new Binding(mesTextBox[i]));
                maGrille.Children.Add(t);
                Grid.SetColumn(t, 1);
                Grid.SetRow(t, i);
            }
            //On génére le bouton ajouter
            Button ajouterBouton = new Button()
            {
                Content = "Ajouter",
            };
            ajouterBouton.SetBinding(Button.CommandProperty, new Binding("ajouterContacVM"));
            Grid.SetColumn(ajouterBouton, 0);
            Grid.SetColumnSpan(ajouterBouton, 2);
            Grid.SetRow(ajouterBouton, 4);
            maGrille.Children.Add(ajouterBouton);
        }

        public void SupprimerContact()
        {

        }

        public void ModifierContact()
        {

        }

        public void ListeContact()
        {

        }

        public void GenerateRowColumn(Grid g, int row, int column)
        {
            for (int i = 0; i < row; i++)
            {
                g.RowDefinitions.Add(new RowDefinition
                {
                    Height = new GridLength(1, GridUnitType.Star)
                });
            }
            for (int i = 0; i < column; i++)
            {
                g.ColumnDefinitions.Add(new ColumnDefinition
                {
                    Width = new GridLength(1, GridUnitType.Star)
                });
            }
        }

        public void Clear()
        {
            maGrille.Children.Clear();
            maGrille.RowDefinitions.Clear();
            maGrille.ColumnDefinitions.Clear();
        }
    }
}

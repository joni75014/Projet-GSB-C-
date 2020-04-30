using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Antibio.Models;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetGsb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageProduits : ContentPage
    {
        int numCateg;
        public PageProduits(int idCateg) // on passe en paramètre un objet de type catégorie
        {
            InitializeComponent();
            numCateg = idCateg;
            // lblTitre.Text = Convert.ToString(libCategorie);
            //initialisation();
            recupAntibiotiques();

        }
        public async void recupAntibiotiques()
        {

            HttpClient wc = new HttpClient();
            var reponse = await wc.GetStringAsync("https://bddjoni.000webhostapp.com/api/getAllAntibioByCateg.php?idCateg=" + numCateg);
            List <Antibio.Models.Antibio> lesAntibiotiques = JsonConvert.DeserializeObject<List<Antibio.Models.Antibio>>(reponse);
            listeAntibiotique.ItemsSource = lesAntibiotiques;
        }



        private void listeAntibiotique_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string DescriptionAntibio = (listeAntibiotique.SelectedItem as Antibio.Models.Antibio).nomAntibio; // on regarde par rapport à la liste des antibiotiques sélectionnés si ils font partie de la classe antibio et si c'est le cas on récupère le libelle
            DisplayAlert("Antibio choisit :", "Vous avez choisi " + DescriptionAntibio, "OK"); // message d'alerte pour indiquer quel est le type de produits sélectionnés
        }

        private void Button_Recherche_Clicked(object sender, EventArgs e)
        {
            if (listeAntibiotique.SelectedItem != null) // on regarde si dans la liste des antibiotiques sélectionnés figurent des Antibios de type AntibioParKilo
            {
                if (Zone_Recherche.Text == null) // si la zone de saisie est nulle on informe l'utilisateur qu'il doit saisir le poid du patient
                {
                    string AntibioUn = (listeAntibiotique.SelectedItem as Antibio.Models.Antibio).unite; // on recupere l'unite  

                    float AntibioParPriseSelectionne = (listeAntibiotique.SelectedItem as Antibio.Models.Antibio).dose_prise; //on recupère la doseprise

                    int AntibioN = (listeAntibiotique.SelectedItem as Antibio.Models.Antibio).nombre_par_jour; //on recup le nombre 

                    DisplayAlert("Prescription", "il vous faut : " + AntibioParPriseSelectionne + AntibioUn + " " + AntibioN + " fois par jour", "OK");

                }

                else
                {
                    string AntibioU = (listeAntibiotique.SelectedItem as Antibio.Models.Antibio).unite; // on declare et on affecte à la variable l'accesseurs get.Unite

                    float saisieU = Convert.ToInt32(Zone_Recherche.Text); // on affecte à la variable saisieU une conversion de la zone de texte qui était une caractère en un nombre entier quelconque

                    float antibioParKiloSelectionne = (listeAntibiotique.SelectedItem as Antibio.Models.Antibio).dose_kilo;// on recupère l'accesseur getDoseKilo

                    int antibioPnombre = (listeAntibiotique.SelectedItem as Antibio.Models.Antibio).nombre_par_jour; //on recupère l'accesseur getNombre qui renvoie le nbParJour

                    saisieU = saisieU * antibioParKiloSelectionne; // calcul avec la variable saisieU

                    DisplayAlert("Prescription", "il vous faut : " + saisieU + " " + AntibioU + " " + antibioPnombre + " fois par jour", "OK"); // On alerte l'utilisateur de la prescription par rapport à la donnée saisie

                }
            }
        }
            //    if (listeAntibiotique.SelectedItem is Antibio.Models.Antibio) // on regarde si dans la liste des antibiotiques sélectionnés figurent des Antibios de type AntibioParPrise
            //    {

            //        if (Zone_Recherche.Text == null)
            //        {

            //            string AntibioUn = (listeAntibiotique.SelectedItem as Antibio.Models.Antibio).unite; // on recupere l'unite  

            //            float AntibioParPriseSelectionne = (listeAntibiotique.SelectedItem as Antibio.Models.Antibio).dose_prise; //on recupère la doseprise

            //            int AntibioN = (listeAntibiotique.SelectedItem as Antibio.Models.Antibio).nombre_par_jour; //on recup le nombre 


            //            DisplayAlert("Prescription", "il vous faut : " + AntibioParPriseSelectionne + AntibioUn + " " + AntibioN + " fois par jour", "OK");

            //        }

            //    }
            //}


        }
    }


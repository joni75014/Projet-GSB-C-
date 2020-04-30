using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Antibio.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ProjetGsb
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //DataAntibio.initialiser(); //initialisation de dataantibio
            //lstCategories.ItemsSource = DataAntibio.getLesCategories().ToList(); //recup la liste des catégories 
            //lstAntibioParKilo.ItemsSource = DataAntibio.getAntibioParKilo().ToList();
            initialisation();
        }

        private async void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (lstCategories.SelectedItem != null)
            {
                await Navigation.PushAsync(new PageProduits((lstCategories.SelectedItem as Categorie).id)); //passer d'une page à l'autre 
            }
        }


    public async void initialisation()
        {
            HttpClient wc = new HttpClient();
            var reponse = await wc.GetStringAsync("https://bddjoni.000webhostapp.com/api/getAllCategorie.php");
            List<Categorie> lesCategories = JsonConvert.DeserializeObject<List<Categorie>>(reponse);
            lstCategories.ItemsSource = lesCategories;
        }

    }
}

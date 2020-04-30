using System;
using System.Collections.Generic;
using System.Text;

namespace Antibio.Models
{
    //class DataAntibio
    //{
        //static private List<Antibio> lesAntibiotiques;
        //static private List<Categorie> lesCategories;
        //static public void initialiser()
       // {
        //    DataAntibio.lesCategories = new List<Categorie>();
        //    Categorie uneCategorie1 = new Categorie("Aminoglycosides");
        //    DataAntibio.lesCategories.Add(uneCategorie1);
        //    Categorie uneCategorie2 = new Categorie("AntiFongiques");
        //    DataAntibio.lesCategories.Add(uneCategorie2);
        //    Categorie uneCategorie3 = new Categorie("Antiviraux");
        //    DataAntibio.lesCategories.Add(uneCategorie3);
        //    Categorie uneCategorie4 = new Categorie("Carbapénèmes");
        //    DataAntibio.lesCategories.Add(uneCategorie4);
        //    Categorie uneCategorie5 = new Categorie("Céphalosporines");
        //    DataAntibio.lesCategories.Add(uneCategorie5);
        //    Categorie uneCategorie6 = new Categorie("Macrolides");
        //    DataAntibio.lesCategories.Add(uneCategorie6);
        //    Categorie uneCategorie7 = new Categorie("Pénicillines");
        //    DataAntibio.lesCategories.Add(uneCategorie7);
        //    Categorie uneCategorie8 = new Categorie("Quinolones");
        //    DataAntibio.lesCategories.Add(uneCategorie8);
        //    Categorie uneCategorie9 = new Categorie("Sulfamidés");
        //    DataAntibio.lesCategories.Add(uneCategorie9);
        //    Categorie uneCategorie10 = new Categorie("Autres");
        //    DataAntibio.lesCategories.Add(uneCategorie10);

        //    DataAntibio.lesAntibiotiques = new List<Antibio>();
        //    AntibioParKilo unAntibioParKilo;
        //    unAntibioParKilo = new AntibioParKilo("Amiklin", "mg/kg",uneCategorie1, 1, 15);
        //    DataAntibio.lesAntibiotiques.Add(unAntibioParKilo);
        //    unAntibioParKilo = new AntibioParKilo("Garamycine", "mg/kg", uneCategorie1, 1, 6);
        //    DataAntibio.lesAntibiotiques.Add(unAntibioParKilo);

        //    AntibioParPrise unAntibioParPrise;
        //    unAntibioParPrise = new AntibioParPrise("Netromycine", "mg/kg", uneCategorie1, 6, 1);
        //    DataAntibio.lesAntibiotiques.Add(unAntibioParPrise);
        //    unAntibioParPrise = new AntibioParPrise("Obracine", "mg/kg", uneCategorie1, 6, 1);
        //    DataAntibio.lesAntibiotiques.Add(unAntibioParPrise);

        //    AntibioParPrise unAntibioParPrise2;
        //    unAntibioParPrise2 = new AntibioParPrise("Flucanazole", "mg", uneCategorie2, 300, 1 );
        //    DataAntibio.lesAntibiotiques.Add(unAntibioParPrise2);
        //    unAntibioParPrise2 = new AntibioParPrise("Itraconazole", "mg", uneCategorie2, 200, 1);
        //    DataAntibio.lesAntibiotiques.Add(unAntibioParPrise2);
     //   }
        
//        static public List<Categorie> getLesCategories()
//        {
//            return DataAntibio.lesCategories;
//        }
//        static public List<Categorie> setLesCategories(Categorie c)
//        {
//            return DataAntibio.lesCategories;
//        }
//        static public List<Antibio> getAntibiotiquesUneCateg(Categorie c)
//        {
//            List<Antibio> liste = new List<Antibio>();
//            foreach (Antibio a in DataAntibio.lesAntibiotiques)
//            {
//                if (a.getCategorie().getLibelle() == c.getLibelle())
//                {
//                    liste.Add(a);
//                }
//            }
//            return liste;
//        }
//         static public List<AntibioParKilo> getAntibioParKilo() // Ecrire une nouvelle méthode getAntibioParKilo()dans la classe DataAntibio, cette méthode renvoie tous les antibiotiques par kilo.
//        {
//            List<AntibioParKilo> liste = new List<AntibioParKilo>();
//            foreach (Antibio a in DataAntibio.lesAntibiotiques)
//            {
//                if (a is AntibioParKilo)

//                {
//                    AntibioParKilo b = (AntibioParKilo)a;
//                    liste.Add(b);
                    
//                }
//            }
//            return liste;
//        }


//    }
//}
}
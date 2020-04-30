using System;
using System.Collections.Generic;
using System.Text;

namespace Antibio.Models
{
    public class Antibio
    {
        public string nomAntibio { get; set; }
        public string unite { get; set; }
        public int nombre_par_jour { get; set; }
        public float dose_prise { get; set; }
        public float dose_kilo { get; set; }


   
            public Antibio(string unNom, string uneUnite, int unNombreParJour, float unDoseKilo, float uneDosePrise)
        {
            this.nomAntibio = unNom;
            this.unite = uneUnite;
            this.nombre_par_jour = unNombreParJour;
            this.dose_kilo = unDoseKilo;
            this.dose_prise = uneDosePrise;
        }



        //    private String libelle;
        //    private String unite;
        //    private Categorie laCategorie;
        //    private int nombreParJour;
        //    private Antibio(String pLibelle, String pUnite, Categorie pCategorie, int pNombre)
        //    {
        //        this.libelle = pLibelle;
        //        this.unite = pUnite;
        //        this.laCategorie = pCategorie;
        //        this.nombreParJour = pNombre;
        //    }
        //    public String getLibelle()
        //    {
        //        return this.libelle;
        //    }
        //    public String getUnite()
        //    {
        //        return this.unite;
        //    }
        //    public Categorie getCategorie()
        //    {
        //        return this.laCategorie;
        //    }
        //    public int getNombre()
        //    {
        //        return this.nombreParJour;
        //    }

        //    public override string ToString()
        //    {
        //        return libelle.ToString();
        //    }


        //}
    }
}

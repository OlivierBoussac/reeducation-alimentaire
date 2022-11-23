using System;

[Serializable]
public class Nutrition
{
    public string AlimentName;
    public float Protéines;
    public float Glucides;
    public float Lipides;
    public float Sucres;
    public float AGSaturés;
    public float Sel;
    public float Prix;
    public string Categorie;
    public float Masse;

    public Nutrition(string AlimentName, float protéines, float glucides, float lipides, float sucres, float agsaturés, float sel, float prix, string categorie, float masse) 
    {
        this.AlimentName = AlimentName;
        this.Protéines = protéines;
        this.Glucides = glucides;
        this.Lipides = lipides;
        this.Sucres = sucres;
        this.AGSaturés = agsaturés;
        this.Sel = sel;
        this.Prix = prix;
        this.Categorie = categorie;
        this.Masse = masse;
    }
}

using System;

[Serializable]
public class Nutrition
{
    public string AlimentName;
    public float Prot�ines;
    public float Glucides;
    public float Lipides;
    public float Sucres;
    public float AGSatur�s;
    public float Sel;
    public float Prix;
    public string Categorie;
    public float Masse;

    public Nutrition(string AlimentName, float prot�ines, float glucides, float lipides, float sucres, float agsatur�s, float sel, float prix, string categorie, float masse) 
    {
        this.AlimentName = AlimentName;
        this.Prot�ines = prot�ines;
        this.Glucides = glucides;
        this.Lipides = lipides;
        this.Sucres = sucres;
        this.AGSatur�s = agsatur�s;
        this.Sel = sel;
        this.Prix = prix;
        this.Categorie = categorie;
        this.Masse = masse;
    }
}

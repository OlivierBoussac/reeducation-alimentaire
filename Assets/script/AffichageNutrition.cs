using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AffichageNutrition : MonoBehaviour
{
    public NutritionManager nutritionManager;
    public Row rowUI;

    //private void Start()
    //{
    //    var nutrition = nutritionManager.GetNutrition("chocolatine");
    //    var row1 = Instantiate(rowUI, transform).GetComponent<Row>();
    //    row1.Aliment.text = "Prot�ines \nGlucides \nLipides \nSucres \nAGSatur�s \nSel\nprix\ncat�gorie\nmasse";
    //    row1.Quantite.text = nutrition.Prot�ines.ToString()+"\n"+nutrition.Glucides.ToString() + "\n" + nutrition.Lipides.ToString() + "\n" + nutrition.Sucres.ToString()
    //        + "\n" + nutrition.AGSatur�s.ToString() + "\n" + nutrition.Sel.ToString() + "\n" + nutrition.Prix.ToString() + "\n" + nutrition.Categorie + "\n" + nutrition.Masse.ToString();
    //}

    private void OnCollisionEnter(Collision collision)
    {
        var nutrition = nutritionManager.GetNutrition(collision.gameObject.name);
        var row1 = Instantiate(rowUI, transform).GetComponent<Row>();
        row1.Aliment.text = "Prot�ines \nGlucides \nLipides \nSucres \nAGSatur�s \nSel\nprix\ncat�gorie\nmasse";
        row1.Quantite.text = nutrition.Prot�ines.ToString() + "\n" + nutrition.Glucides.ToString() + "\n" + nutrition.Lipides.ToString() + "\n" + nutrition.Sucres.ToString()
            + "\n" + nutrition.AGSatur�s.ToString() + "\n" + nutrition.Sel.ToString() + "\n" + nutrition.Prix.ToString() + "\n" + nutrition.Categorie + "\n" + nutrition.Masse.ToString();
    }
}

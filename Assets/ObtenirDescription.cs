using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ObtenirDescription : MonoBehaviour
{
    public NutritionManager NutritionManager;
    public Row row;
    private XRRayInteractor RayinteractorL = null;
    private XRRayInteractor RayinteractorR = null;
    // Start is called before the first frame update
    void Start()
    {
        NutritionManager = GameObject.Find("nutritionManager").GetComponent<NutritionManager>();
        //row = GameObject.Find("Content").GetComponent<Row>();
        RayinteractorL = GameObject.Find("Left Grab Ray").GetComponent<XRRayInteractor>();
        RayinteractorL.onHoverEntered.AddListener(HoverEnterEvent);
        RayinteractorL.onSelectExited.AddListener(EndInput);
        RayinteractorR = GameObject.Find("Right Grab Ray").GetComponent<XRRayInteractor>();
        RayinteractorR.onHoverEntered.AddListener(HoverEnterEvent);
        RayinteractorR.onSelectExited.AddListener(EndInput);
    }

    // Update is called once per frame
    private void HoverEnterEvent(XRBaseInteractable interactable)
    {

        int nbChildren = GameObject.Find("Content").transform.childCount;

        for (int i = nbChildren - 1; i >= 0; i--)
        {
            Debug.Log(i);
            DestroyImmediate(GameObject.Find("Content").transform.GetChild(i).gameObject);
        }

        Nutrition nutrition = NutritionManager.GetNutrition(interactable.name);
        //row.Aliment.SetText(interactable.name);
        if (nutrition != null)
        {
           var row1 = Instantiate(row, transform).GetComponent<Row>();
            row1.Aliment.text = "Protéines \nGlucides \nLipides \nSucres \nAGSaturés \nSel\nprix\ncatégorie\nmasse";
            row1.Quantite.text = nutrition.Protéines.ToString() + "\n" + nutrition.Glucides.ToString() + "\n" + nutrition.Lipides.ToString() + "\n" + nutrition.Sucres.ToString()
                + "\n" + nutrition.AGSaturés.ToString() + "\n" + nutrition.Sel.ToString() + "\n" + nutrition.Prix.ToString() + "\n" + nutrition.Categorie + "\n" + nutrition.Masse.ToString();


        }
    }

    private void EndInput(XRBaseInteractable interactable)
    {

    }

}

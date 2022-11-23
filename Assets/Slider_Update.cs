using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Slider_Update : MonoBehaviour
{
    public TextMeshProUGUI TailleText;
    public TextMeshProUGUI PoidsText;
    void Start()
    {

        TailleText = GameObject.Find("Value_Taille").GetComponent<TextMeshProUGUI>();
        PoidsText = GameObject.Find("Value_Poids").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
   public void UpdateTaille(float value)
    {
        TailleText.text = value.ToString();
    }
    public void UpdatePoids(float value)
    {
        PoidsText.text = value.ToString();
    }
}

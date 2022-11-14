using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class General : MonoBehaviour
{
    public float Total;
    // Start is called before the first frame update
    void Start()
    {
        Total = 0.00f;
    }

    // Update is called once per frame
    void Update()
    {
       GameObject.Find("Total_text2").GetComponent<TextMeshProUGUI>().text = Total.ToString()+ " €";
    }
}

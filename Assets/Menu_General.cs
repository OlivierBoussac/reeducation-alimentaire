using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_General : MonoBehaviour
{
    public string test;
    private string Desc;
    public TextMeshProUGUI textDesc;
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI textDesc = new TextMeshProUGUI();
      


    }

    // Update is called once per frame
    void Update()
    {
        if (Desc != null)
        {
            GameObject.Find("Description").GetComponent<TextMeshProUGUI>().text = Desc;
        }
    }

    public void LancerGeneration()
    {
        SceneManager.LoadScene("VR Test");
    }

    public void setDesc (string description)
    {
        Desc = description;
    }
}

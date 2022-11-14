using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_General : MonoBehaviour
{
    public string test;
    public TextMeshProUGUI Desc;
    public TextMeshProUGUI textDesc;
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI textDesc = new TextMeshProUGUI();
        textDesc = GameObject.Find("Description").GetComponent<TextMeshProUGUI>();  


    }

    // Update is called once per frame
    void Update()
    {
       // textDesc.text = "hi"; 
    }

    public void LancerGeneration()
    {
        SceneManager.LoadScene("VR Test");
    }
}

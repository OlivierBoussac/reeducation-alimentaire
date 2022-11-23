using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Menu_General : MonoBehaviour
{
    public string test;
    private string Desc;
    public TextMeshProUGUI textDesc;
    public bool enabledMove;
    public bool rightHand; 
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI textDesc = new TextMeshProUGUI();
      enabledMove = true;
        rightHand = true;


    }

    // Update is called once per frame
    void Update()
    {
  /*      if (Desc != null)
        {
            GameObject.Find("Description").GetComponent<TextMeshProUGUI>().text = Desc;
        }*/
    }

    public void LancerGeneration()
    {
        DontDestroyOnLoad(GameObject.Find("Menu_General"));
        SceneManager.LoadScene("VR Test");
        GameObject xr = GameObject.Find("XR Origin");
        xr.GetComponent<ContinuousTurnProviderBase>().enabled = false;
    }

    public void setDesc (string description)
    {
        Desc = description;
        GameObject.Find("Description").GetComponent<TextMeshProUGUI>().text = Desc;
    }

    public void setMove(bool move)
    {
        Debug.Log(move);
        enabledMove = move;
    }

    public void setHand(bool rhand)
    {
        rightHand = rhand;
    }

    public void setrightorleft(GameObject hand)
    {
        
        if(GameObject.Find("Main_Droite") == hand)
        {
    
             //GameObject.Find("Main_Droite").GetComponent<Toggle>().isOn = true;
               GameObject.Find("Main_Gauche").GetComponent<Toggle>().isOn = false;
            rightHand = true;
        } else if (GameObject.Find("Main_Gauche") == hand)
        {
                 GameObject.Find("Main_Droite").GetComponent<Toggle>().isOn = false;
                // GameObject.Find("Main_Gauche").GetComponent<Toggle>().isOn = true;
            rightHand = false;
        }

    }



}

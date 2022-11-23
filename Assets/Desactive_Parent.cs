using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.Interaction.Toolkit;

public class Desactive_Parent : MonoBehaviour
{
    private XRDirectInteractor interactor = null;
    private XRRayInteractor RayinteractorL = null;
    private XRRayInteractor RayinteractorR = null;
    public GameObject Princial;
    private Coller_au_plateau verifiecolle;
    private GameObject objet;
    private General gen;
    // Start is called before the first frame update
    void Start()
    {
        //Principal = GameObject.Find("Principal");
        objet = GameObject.Find("Principal");
        verifiecolle = objet.GetComponent<Coller_au_plateau>();
        gen = GameObject.Find("XR Origin").GetComponent<General>();
        interactor = GetComponent<XRDirectInteractor>();
        interactor.onSelectEntered.AddListener(TakeInput);
        RayinteractorL = GameObject.Find("Left Grab Ray").GetComponent<XRRayInteractor>();
        RayinteractorL.onSelectEntered.AddListener(TakeInput);
        RayinteractorL.onSelectExited.AddListener(EndInput);
        RayinteractorR = GameObject.Find("Right Grab Ray").GetComponent<XRRayInteractor>();
        RayinteractorR.onSelectEntered.AddListener(TakeInput);
        RayinteractorR.onSelectExited.AddListener(EndInput);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("test");
    }

    private void TakeInput(XRBaseInteractable interactable)
    {
        
        if(interactable.name == verifiecolle.objet && verifiecolle.objectcollé == true)
        {
           
            verifiecolle.colle = false;
            verifiecolle.objectcollé = false;
            GameObject.Find("Contenu").GetComponent<TextMeshProUGUI>().text = "";
            gen.Total -= 1.50f;
            Princial.GetComponent<BoxCollider>().isTrigger = false;
        }
       

    }

    private void EndInput(XRBaseInteractable interactable) 
    {
        Princial.GetComponent<BoxCollider>().isTrigger = true;
    }

}

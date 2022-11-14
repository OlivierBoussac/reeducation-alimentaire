using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.Interaction.Toolkit;

public class Desactive_Parent : MonoBehaviour
{
    private XRDirectInteractor interactor = null;
   private Coller_au_plateau verifiecolle;
    private GameObject objet;
    // Start is called before the first frame update
    void Start()
    {
        objet = GameObject.Find("Principal");
        verifiecolle = objet.GetComponent<Coller_au_plateau>();
        interactor = GetComponent<XRDirectInteractor>();
        interactor.onSelectEntered.AddListener(TakeInput);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("test");
    }

    private void TakeInput(XRBaseInteractable interactable)
    {

        if(interactable.tag == "Food")
        {
            verifiecolle.colle = false;
        }
        //Debug.Log(verifiecolle.colle);

    }
}

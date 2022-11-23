using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

public class General : MonoBehaviour
{
    public float Total;
    public Menu_General menu;
    public GameObject leftray;
    public GameObject rightray;
    // Start is called before the first frame update
    void Start()
    {
        menu = GameObject.Find("Menu_General").GetComponent<Menu_General>();
        Total = 0.00f;
    }

    // Update is called once per frame
    void Update()
    {
        
        GameObject.Find("Total_text2").GetComponent<TextMeshProUGUI>().text = Total.ToString()+ " €";

        if(menu.enabledMove == false)
        {
            GameObject.Find("XR Origin").GetComponent<ContinuousMoveProviderBase>().enabled = false;
        }

        if(menu.rightHand == false)
        {
            GameObject.Find("XR Origin").GetComponent<ContinuousMoveProviderBase>().system.GetComponent<ActionBasedContinuousMoveProvider>().leftHandMoveAction.action.Disable();
            GameObject.Find("XR Origin").GetComponent<ContinuousMoveProviderBase>().system.GetComponent<ActionBasedContinuousMoveProvider>().rightHandMoveAction.action.Enable();
            // GameObject.Find("XR Origin").GetComponent<Activate_Teleportation_Ray>().enabled = false;
            rightray.GetComponent<LineRenderer>().enabled = false;
            rightray.GetComponent<XRInteractorLineVisual>().enabled = false;
            rightray.GetComponent<XRRayInteractor>().enabled = false;

           // GameObject.Find("XR Origin").GetComponent<Activate_Teleportation_Ray_Gauche>().enabled = true;
            leftray.GetComponent<XRRayInteractor>().enabled = true;
            leftray.GetComponent<XRInteractorLineVisual>().enabled = true;
        }
    }
}

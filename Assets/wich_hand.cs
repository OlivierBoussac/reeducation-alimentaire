using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class wich_hand : MonoBehaviour
{
    public XRDirectInteractor rHand;
    public XRDirectInteractor lHand;
    public Transform Attach1;
    public Transform Attach2;


    // Start is called before the first frame update
    void Start()
    {

        // rHand = GameObject.Find("Main Droite");
        // lHand = GameObject.Find("Main Gauche");
    }

    // Update is called once per frame
    void Update()
    {
        if (rHand.selectTarget != null)
        {
            if (rHand.selectTarget.tag == "Plate")
            {
                this.GetComponent<XRGrabInteractable>().attachTransform = Attach2;
            }
        }

        if (lHand.selectTarget != null)
        {
            //Debug.Log("test");
            if (lHand.selectTarget.tag == "Plate")
            {
                this.GetComponent<XRGrabInteractable>().attachTransform = Attach1;
            }
        }

        Physics.IgnoreLayerCollision(6, 7, true);



    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colle : MonoBehaviour
{
    private Vector3 decalage;
    private GameObject Grab1;
    // Start is called before the first frame update
    void Start()
    {
        Grab1 = GameObject.Find("Grab1");
        decalage = new Vector3(0.40f,0,0);
    }

    // Update is called once per frame
    void Update()
    {
       // this.transform.position = Grab1.transform.position - decalage ;
        //Grab1.transform.Rotate(new Vector3(0, 0, 0));
    }
}

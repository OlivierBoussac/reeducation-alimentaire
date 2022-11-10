using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coller_au_plateau : MonoBehaviour
{
    public GameObject Plateau;
    public Collider objec;
    public bool colle;
    public Vector3 diff;
    // Start is called before the first frame update
    void Start()
    {
        Plateau = GameObject.Find("Tray_low");
        colle = false;
        diff = new Vector3(0, -0.05f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(colle == true)
        {
            objec.transform.position = this.transform.position + diff;
            objec.transform.rotation = this.transform.rotation * Quaternion.Euler(-90,0,0) ;
            Debug.Log(this.transform.position);
        }
    }

   private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Food")
        {
            objec = other;
            colle = true;
          
        }
    }
}

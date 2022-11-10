using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colle2 : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 decalage;
    private GameObject Grab1;
    // Start is called before the first frame update
    void Start()
    {
        Grab1 = GameObject.Find("Grab2");
        decalage = new Vector3(-0.80f, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Grab1.transform.position - decalage;
        Grab1.transform.Rotate(new Vector3(0, 0, 0));
    }
}

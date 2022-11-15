using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coller_au_plateau : MonoBehaviour
{
    public GameObject Plateau;
    public Collider objec;
    public bool colle;
    public bool objectcollé;
    public Vector3 diff;
    public General gen;
    // Start is called before the first frame update
    void Start()
    {
        Plateau = GameObject.Find("Tray_low");
        colle = false;
        objectcollé = false;
        diff = new Vector3(0, -0.05f, 0);
        gen = GameObject.Find("XR Origin").GetComponent<General>();
    }

    // Update is called once per frame
    void Update()
    {
        if (colle == true)
        {
            objec.transform.position = this.transform.position + diff;
            objec.transform.rotation = this.transform.rotation * Quaternion.Euler(-90, 0, 0);
            //Debug.Log(this.transform.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Food" && objectcollé == false)
        {
            objec = other;
            colle = true;
            GameObject.Find("Contenu").GetComponent<TextMeshProUGUI>().text = other.name + " - 1.50 €";
            gen.Total += 1.50f;
        }
    }

    public virtual void OnTriggerStay(Collider other)
    {
        objectcollé = true;
    }



    }
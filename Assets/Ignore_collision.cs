using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ignore_collision : MonoBehaviour
{
    CharacterController charCon;

    // Start is called before the first frame update
    void Start()
    {
   

        charCon = this.GetComponent<CharacterController>();
        Physics.IgnoreLayerCollision(8, 0, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

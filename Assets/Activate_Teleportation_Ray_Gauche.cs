using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Activate_Teleportation_Ray_Gauche : MonoBehaviour
{
    public GameObject leftTeleportation;

    public InputActionProperty leftActivate;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        leftTeleportation.SetActive(leftActivate.action.ReadValue<float>() > 0.1f);
    }
}

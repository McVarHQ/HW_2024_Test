using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoPulpitDetection : MonoBehaviour
{

    public Rigidbody rb;
    private void OnTriggerExit(Collider other)
    {
        rb.isKinematic = false;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Renderer>().enabled) rb.isKinematic = true;
        else rb.isKinematic = false;
            
    }
}

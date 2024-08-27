using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoPulpitDetection : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        rb.isKinematic = false;
    }
    private void OnTriggerStay(Collider other)
    {
        Rigidbody r = other.GetComponent<Rigidbody>();
        r.isKinematic = true;
    }
}

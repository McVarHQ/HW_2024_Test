using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoPulpitDetection : MonoBehaviour
{

    public Rigidbody rb;
    public bool isOut = false;
    private void OnTriggerExit(Collider other)
    {
        rb.isKinematic = false;
        StartCoroutine(waittime());

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Renderer>().enabled & !isOut) rb.isKinematic = true;
        else
        {
            isOut = true;
            rb.isKinematic = false;
        }
    }

    IEnumerator waittime()
    {
        yield return new WaitForSeconds(1);

        if(rb.isKinematic == false) isOut = true;
    }
}

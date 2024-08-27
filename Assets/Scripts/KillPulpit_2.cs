using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPulpit_2 : MonoBehaviour
{
    public Transform target;
    public float x = 2.5f, y = 4, z = 5;
    public float rand;

    void OnEnable()
    {
        rand = Random.Range(y, z);
        Debug.Log(rand);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rand -= Time.deltaTime;

        if (rand <= 2.5)
        {
            if (target.GetComponent<Renderer>().enabled == false)
            {
                target.GetComponent<KillPulpit_2>().rand = Random.Range(y, z);
                target.GetComponent<Renderer>().enabled = true;
            }
        }

        if (target.GetComponent<KillPulpit_2>().rand <= 0)
        {
            target.GetComponent<Renderer>().enabled = false;
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeLocation : MonoBehaviour
{

    public Transform target;
    private List<int> opt = new List<int>();
    private float X, Z;
    public float x, z;
    private int rand;
    public bool placed = false;
    void Start()
    {
        opt.Add(9);
        opt.Add(-9);
        x = transform.position.x;
        z = transform.position.z;
    }

   
    void FixedUpdate()
    {
        if ((transform.GetComponent<Renderer>().enabled) == false & (placed == false))
        {
            X = target.position.x;
            Z = target.position.z;

            rand = Random.Range(0, 2);
            if (rand == 0)
            {
                rand = opt[Random.Range(0, 2)];
                if (X + rand != x)
                {
                    transform.position = new Vector3(X + rand, 0, Z);
                }
                else
                {
                    transform.position = new Vector3(X - rand, 0, Z);
                }
            }
            else
            {
                rand = opt[Random.Range(0, 2)];
                if (Z + rand != z)
                {
                    transform.position = new Vector3(X, 0, Z + rand);
                }
                else
                {
                    transform.position = new Vector3(X, 0, Z - rand);
                }
            }

            placed = true;
        }
        else
        {
            x = transform.position.x;
            z = transform.position.z;
        }

    }
    
}

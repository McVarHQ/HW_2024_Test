using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    public Transform Controller;
    public bool flag = false;

    private void OnTriggerEnter(Collider other)
    {
        if (flag) return;

        Controller.GetComponent<ControlCenter>().score += 1;
        flag = true;
    }
}

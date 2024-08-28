using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    public Transform Controller;
    public bool flag = false;
    public TextMeshProUGUI text;

    private void OnTriggerEnter(Collider other)
    {
        if (flag) return;

        Controller.GetComponent<ControlCenter>().score += 1;
        text.text = Controller.GetComponent<ControlCenter>().score.ToString();
        flag = true;
    }
}

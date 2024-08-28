using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class setScore : MonoBehaviour
{
    public GameObject bg;
    public TextMeshProUGUI text;
    private float f;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        bg.SetActive(transform.GetComponent<Renderer>().enabled);
        f = transform.GetComponent<KillPulpit_2>().rand;
        text.text = (Mathf.Round(f * 100.0f) * 0.01f).ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTimer : MonoBehaviour
{
    public Color[] colors;
    public Material material;
    private int curr;
    private int target;
    private float point;
    public float duration = 5;

    private void Update()
    {
        point +=Time.deltaTime/duration;
        material.color = Color.Lerp(colors[curr], colors[target], point);

        if (point >= 1)
        {
            point = 0;
            curr = target;
            target++;

            if (target >= colors.Length)
            {
                target = 0;
            }
        }
    }
}

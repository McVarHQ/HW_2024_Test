using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public TextAsset doofus_diary;
    private bool isMoving = false;
    private float speed;

    void Start()
    {
        speed = 3;
        Debug.Log(speed);
    }

    void Update()
    {
        if (isMoving) return;

        if (Input.GetKey(KeyCode.W)) helper(Vector3.forward);
        else if (Input.GetKey(KeyCode.A)) helper(Vector3.left);
        else if (Input.GetKey(KeyCode.S)) helper(Vector3.back);
        else if (Input.GetKey(KeyCode.D)) helper(Vector3.right);

        void helper(Vector3 direction)
        {
            var pivot = transform.position + (Vector3.down + direction) * 0.5f;
            var axis = Vector3.Cross(Vector3.up, direction);
            StartCoroutine(move(pivot, axis));
        }

    }


    IEnumerator move(Vector3 pivot, Vector3 axis)
    {
        isMoving = true;

        for(int i = 0; i < (90 / speed); i++)
        {
            transform.RotateAround(pivot, axis, speed);
            yield return new WaitForSeconds(0.01f);
        }

        isMoving = false;
    }

}

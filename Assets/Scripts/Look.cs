using UnityEngine;
// This complete script can be attached to a camera to make it
// continuously point at another object.

public class Look : MonoBehaviour
{
    public Transform target;
    private float moveX, moveY;

    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical")*0.5f;

        transform.Translate(new Vector3(moveX, moveY, moveY) * Time.deltaTime);

    }
}
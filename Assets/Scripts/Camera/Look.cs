using UnityEngine;
// This complete script can be attached to a camera to make it
// continuously point at another object.

public class Look : MonoBehaviour
{
    public Transform target;
    private float speed;

    void Update()
    {
        //if (target.GetComponent<NoPulpitDetection>().isOut) return;

        transform.position = new Vector3(target.position.x, target.position.y + 8.25f, target.position.z - 9);

    }
}
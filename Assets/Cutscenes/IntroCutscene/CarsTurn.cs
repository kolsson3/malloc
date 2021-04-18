using UnityEngine;
using System.Collections;

public class CarsTurn : MonoBehaviour
{
    public Transform target;
    public Transform target2;
    public bool activated = false;
    public float speed;
    public bool turning = false;

    void Update()
    {
        float step = speed * Time.deltaTime;
        if (activated)
        {
            if (turning)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, -90, 0), Time.deltaTime * 3);
                transform.position = Vector3.MoveTowards(transform.position, target2.position, 3 * Time.deltaTime);
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            }
        }
    }

    public void activateTheCar()
    {
        activated = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        turning = true;
    }

}
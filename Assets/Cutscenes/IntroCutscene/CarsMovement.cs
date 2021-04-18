using UnityEngine;
using System.Collections;

public class CarsMovement : MonoBehaviour
{
    public Transform target;
    public bool isPOVCar;
    public bool activated = false;
    public float speed;

    void Update()
    {
        if (activated)
        {
            // The step size is equal to speed times frame time.
            float step = speed * Time.deltaTime;

            // Move our position a step closer to the target.
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

    public void activateTheCar()
    {
        activated = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "GoingNorthTrigger" || other.gameObject.name == "GoingNorthTrigger")
        {
            gameObject.SetActive(false);
        }
    }

}
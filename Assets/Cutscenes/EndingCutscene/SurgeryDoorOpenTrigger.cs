using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurgeryDoorOpenTrigger : MonoBehaviour
{
    public GameObject door;
    public bool doorOpened = false;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        doorOpened = true;
    }

    private void Update()
    {
        door.gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 90, 0), Time.deltaTime * 3);
    }
}

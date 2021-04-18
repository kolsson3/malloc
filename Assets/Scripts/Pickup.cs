using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject heldItem;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GrabObject(GameObject toGrab)
    {
        Debug.Log("pickup");
        if(heldItem == null)
        {
            Debug.Log("null");
            heldItem = toGrab;
            toGrab.transform.position = target.transform.position;
            toGrab.transform.parent = target.transform;
            toGrab.gameObject.GetComponent<Collider>().enabled = false;
        }
        else
        {
            Debug.Log("not null");
            heldItem.transform.position = toGrab.transform.position;
            heldItem.transform.parent = toGrab.transform.parent;
            heldItem.gameObject.GetComponent<Collider>().enabled = true;
            heldItem = toGrab;
            toGrab.transform.position = target.transform.position;
            toGrab.transform.parent = target.transform;
            toGrab.gameObject.GetComponent<Collider>().enabled = false;
        }
    }

    public string HeldName()
    {
        return heldItem == null ? "none" : heldItem.name;
    }

}

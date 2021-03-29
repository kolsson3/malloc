using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraNode : MonoBehaviour
{
    Movement mainCamera;

    public bool closeup = false;
    public bool transition = false;

    public CameraNode nextNode;

    public CameraNode previousNode;

    public List<CameraNode> linkedNodes;

    void Start()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Movement>();
    }

    void OnMouseDown()
    {
        Debug.Log("Clicked on " + gameObject.name);
        if (mainCamera.currentNode.linkedNodes.Contains(this) && !mainCamera.inDialogue) MoveTo();
    }

    public void MoveTo()
    {
        mainCamera.transform.position = this.transform.position;
        mainCamera.currentNode = this;
        if (closeup) mainCamera.transform.rotation = this.transform.rotation;
        if (transition) Transition();
    }

    public void Backup()
    {
        if (previousNode != null)
        {
            mainCamera.transform.rotation = previousNode.transform.rotation;
            previousNode.MoveTo();
        }
    }

    public void Transition()
    {
        mainCamera.transform.position = nextNode.transform.position;
        mainCamera.currentNode = nextNode;
    }
}

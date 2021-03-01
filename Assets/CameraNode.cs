using UnityEngine;

public class CameraNode : MonoBehaviour
{
    MystMovement mainCamera;

    public bool closeup = false;

    public CameraNode previousNode;

    void Start()
    {
        mainCamera = GameObject.Find("MainCamera").GetComponent<MystMovement>();
    }

    void OnMouseDown()
    {
        Debug.Log("Clicked on " + gameObject.name);
        if(!mainCamera.inDialogue) MoveTo();
    }

    public void MoveTo()
    {
        mainCamera.transform.position = this.transform.position;
        mainCamera.currentNode = this;
        if (closeup) mainCamera.transform.rotation = this.transform.rotation;
    }

    public void Backup()
    {
        if (previousNode != null)
        {
            mainCamera.transform.rotation = previousNode.transform.rotation;
            previousNode.MoveTo();
        }
    }
}

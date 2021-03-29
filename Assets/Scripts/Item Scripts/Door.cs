using UnityEngine;

public class Door : MonoBehaviour
{
    GameObject mainCamera;

    public float openThreshold = 3f;
    public bool open = false;
    public bool locked = false;

    void Start()
    {
        mainCamera = GameObject.Find("Main Camera");
    }

    void OnMouseDown()
    {
        float dist = Vector3.Distance(this.transform.position, mainCamera.transform.position);
        Debug.Log("Distance to door " + dist);
        if (dist < openThreshold && !locked)
        {
            if(!open)this.transform.Rotate(0f, -85f, 0f);
            else this.transform.Rotate(0f, 85f, 0f);
            open = !open;
        }
    }
}

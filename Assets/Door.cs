using UnityEngine;

public class Door : MonoBehaviour
{
    GameObject mainCamera;

    public float openThreshold = 2.5f;
    public bool open = false;

    void Start()
    {
        mainCamera = GameObject.Find("MainCamera");
    }

    void OnMouseDown()
    {
        float dist = Vector3.Distance(this.transform.position, mainCamera.transform.position);
        Debug.Log("Distance to door " + dist);
        if (dist < openThreshold)
        {
            if(!open)this.transform.Rotate(0f, -85f, 0f);
            else this.transform.Rotate(0f, 85f, 0f);
            open = !open;
        }
    }
}

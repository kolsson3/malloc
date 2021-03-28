using UnityEngine;
using UnityEngine.UI;

public class InventoryCamera : MonoBehaviour
{
    [HideInInspector] private Camera thisCamera;

    [HideInInspector] public GameObject inventoryItem = null;

    // Start is called before the first frame update
    void Start()
    {
        this.thisCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    
    void Update()
    {
        if (this.inventoryItem == null) return;


        this.inventoryItem.transform.position = this.thisCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.1f, 0.4f));
        this.inventoryItem.transform.rotation = new Quaternion(0.0f, this.transform.rotation.y, 0.2f, this.transform.rotation.w);
        this.inventoryItem.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
    }
}

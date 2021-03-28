using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    [SerializeField] private InventoryCamera inventoryCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Clicked on " + gameObject.name);
        if (this.inventoryCamera.inventoryItem == null)
        {
            this.inventoryCamera.inventoryItem = this.gameObject;
            this.inventoryCamera.inventoryItem.layer = 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

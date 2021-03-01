using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    public InventoryObject inventoryObject;
    // Start is called before the first frame update
    void Start()
    {
        this.inventoryObject.Attach(this.gameObject);
    }

    void OnMouseDown()
    {
        Debug.Log("Clicked on " + gameObject.name);
        if (inventoryObject.state == InventoryObject.State.World) this.AppendInventory();
    }

    public void AppendInventory()
    {
        this.inventoryObject.AppendInventory();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

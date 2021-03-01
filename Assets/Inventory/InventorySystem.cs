using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    // Singleton
    public static InventorySystem instance { get; private set; }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            instance.inventory = new List<InventoryObject>();
        }
    }

    // List
    private List<InventoryObject> inventory;
    public void Append(InventoryObject inventoryObject) => inventory.Add(inventoryObject);

    public void Remove(InventoryObject inventoryObject) => inventory.Remove(inventoryObject);
    public int Length() => inventory.Count;

    public void Show(Transform t, Camera c)
    {
        for (int i = 0; i < inventory.Count; ++i)
        {
            inventory[i].Show(i, t, c);
        }
    }
}

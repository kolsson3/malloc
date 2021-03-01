using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCamera : MonoBehaviour
{
    [HideInInspector] private Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        this.camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    
    void Update()
    {
        InventorySystem.instance.Show(this.transform, this.camera);
    }
}

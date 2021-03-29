using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sink : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("MainCamera");
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (player.GetComponent<Pickup>().HeldName() == "SM_Prop_Coffee_Pot_01")
        {
            player.GetComponent<Pickup>().heldItem.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}

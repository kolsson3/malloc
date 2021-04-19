using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMachine : MonoBehaviour
{
    GameObject player;
    public bool hasWater = false;
    public bool hasPot = false;
    public bool hasGrounds = false;
    public bool coffeeReady = false;
    public bool puzzleComplete = false;

    GameObject coffeePot;
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        player = GameObject.Find("Main Camera");
    }

    void OnMouseDown()
    {
        string heldName = player.GetComponent<Pickup>().HeldName();


        if (heldName == "SM_Prop_Coffee_Pot_01")
        {
            if (player.GetComponent<Pickup>().heldItem.transform.GetChild(0).gameObject.activeSelf)
            {
                player.GetComponent<Pickup>().heldItem.transform.GetChild(0).gameObject.SetActive(false);
                hasWater = true;
            }
            else if (hasWater)
            {
                player.GetComponent<Pickup>().heldItem.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 0.08f, this.transform.position.z);
                player.GetComponent<Pickup>().heldItem.transform.parent = this.transform;
                coffeePot = player.GetComponent<Pickup>().heldItem;
                player.GetComponent<Pickup>().heldItem.gameObject.GetComponent<KeyItem>().enabled = false;
                player.GetComponent<Pickup>().heldItem = null;
                hasPot = true;
                if(hasGrounds)
                {
                    coffeePot.transform.GetChild(1).gameObject.SetActive(true);
                }
            }
        }
        else if (heldName == "SM_Prop_Jar_01" && gm.firstHubVisit)
        {
            hasGrounds = true;
            Destroy(player.GetComponent<Pickup>().heldItem.gameObject);
            if (hasWater && hasPot)
            {
                coffeePot.transform.GetChild(1).gameObject.SetActive(true);
            }
        }
        else if (hasPot && hasWater && hasGrounds && heldName == "SM_Item_Mug_01")
        {
            player.GetComponent<Pickup>().heldItem.transform.GetChild(0).gameObject.SetActive(true);
            puzzleComplete = true;
        }
    }
}

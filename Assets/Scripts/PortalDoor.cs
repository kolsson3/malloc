using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalDoor : MonoBehaviour
{
    

    void OnMouseDown()
    {
        if (!this.gameObject.GetComponent<Door>().locked)
        {
            GameObject.Find("Character_Mother").GetComponent<ConversationTrigger>().hasOpenedPantry = true;
        }
    }
}

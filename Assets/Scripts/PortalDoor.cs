using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalDoor : MonoBehaviour
{
    

    void OnMouseDown()
    {
        if (!this.gameObject.GetComponent<Door>().locked)
        {
            Debug.Log("Should fire");
            GameObject.Find("Character_Mother_02").GetComponent<ConversationTrigger>().hasOpenedPantry = true;
        }
    }
}

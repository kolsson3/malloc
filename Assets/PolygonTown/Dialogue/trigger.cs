using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class trigger : MonoBehaviour
{
    public NPCConversation myConversation;

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ConversationManager.Instance.StartConversation(myConversation);
        }
    }
}

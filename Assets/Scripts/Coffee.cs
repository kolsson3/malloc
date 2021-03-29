using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Coffee : MonoBehaviour
{
    public NPCConversation convo;
    public ConversationTrigger momConvo;

    private void OnMouseDown()
    {
        ConversationManager.Instance.StartConversation(convo);
        momConvo.needsCoffee = true;
    }
}
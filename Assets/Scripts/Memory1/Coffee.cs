using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Coffee : MonoBehaviour
{
    public NPCConversation convo;
    public ConversationTrigger momConvo;
    public GameManager gm;

    public void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnMouseDown()
    {
        if(!gm.firstHubVisit)
        {
            ConversationManager.Instance.StartConversation(convo);
            momConvo.needsCoffee = true;
        }   
    }
}
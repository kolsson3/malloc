﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class BirthdayAshDialogue : MonoBehaviour
{
    public NPCConversation initConvo;
    public NPCConversation loopConvo;
    bool init = false;

    private void OnMouseDown()
    {
        if (!GameObject.Find("GameManager").GetComponent<GameManager>().firstSpeech && (ConversationManager.Instance == null || !ConversationManager.Instance.IsConversationActive))
        {
            if (!init)
            {
                init = true;
                ConversationManager.Instance.StartConversation(initConvo);

            }
            else
            {
                ConversationManager.Instance.StartConversation(loopConvo);
            }
        }
    }
}

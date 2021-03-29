using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Movement : MonoBehaviour
{
    public CameraNode currentNode;
    public bool inDialogue;

    void Update()
    {
        if (ConversationManager.Instance != null && ConversationManager.Instance.IsConversationActive) inDialogue = true;
        else inDialogue = false;


        if (Input.GetMouseButtonDown(0) && !inDialogue)
        {
            Vector3 p = Input.mousePosition;

            if (currentNode.closeup && p.y < Screen.height / 10)
            {
                Debug.Log("Backup");
                if (currentNode.closeup) currentNode.Backup();
            }
            else if (!currentNode.closeup && p.x < Screen.width / 10)
            {
                Debug.Log("Turn Left");
                transform.Rotate(0f, -90f, 0f);
            }
            else if (!currentNode.closeup && p.x > Screen.width * 0.9)
            {
                Debug.Log("Turn right");
                transform.Rotate(0f, 90f, 0f);
            }
            else
            {
                Debug.Log("Click at " + p.x + " and " + p.y);
            }
        }
    }
}

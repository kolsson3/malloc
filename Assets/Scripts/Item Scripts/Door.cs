using UnityEngine;
using DialogueEditor;

public class Door : MonoBehaviour
{
    GameObject mainCamera;

    public float openThreshold = 5f;
    public bool open = false;
    public bool locked = false;

    public NPCConversation lockedText;

    void Start()
    {
        mainCamera = GameObject.Find("Main Camera");
    }

    void OnMouseDown()
    {
        float dist = Vector3.Distance(this.transform.position, mainCamera.transform.position);
        Debug.Log("Distance to door " + dist);
        if (dist < openThreshold)
        {
            if (!locked)
            {
                if (!open) this.transform.Rotate(0f, -85f, 0f);
                else this.transform.Rotate(0f, 85f, 0f);
                open = !open;
            }
            else
            {
                lockedText = GameObject.Find("LockedDoor").GetComponent<NPCConversation>();
                ConversationManager.Instance.StartConversation(lockedText);
            }
        } 

    }
}

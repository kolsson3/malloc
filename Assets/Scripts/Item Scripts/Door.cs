using UnityEngine;
using DialogueEditor;

public class Door : MonoBehaviour
{
    GameObject mainCamera;

    public float openThreshold = 5f;
    public bool open = false;
    public bool locked = false;

    public NPCConversation lockedText;

    AudioSource doorAudio;
    AudioClip doorLocked;
    AudioClip doorOpen;

    //Resources.Load("magnifier") as Texture2D

    void Start()
    {
        mainCamera = GameObject.Find("Main Camera");

        doorAudio = gameObject.AddComponent(typeof(AudioSource)) as AudioSource;
        doorLocked = Resources.Load("door_locked") as AudioClip;
        doorOpen = Resources.Load("door_open") as AudioClip;
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
                doorAudio.PlayOneShot(doorOpen, 1.0f);
            }
            else
            {
                lockedText = GameObject.Find("LockedDoor").GetComponent<NPCConversation>();
                ConversationManager.Instance.StartConversation(lockedText);
                doorAudio.PlayOneShot(doorLocked, 0.75f);
            }
        } 

    }
}

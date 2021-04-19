using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class MovingPuzzle : MonoBehaviour
{
    public NPCConversation questinit;
    public NPCConversation questloop;
    public NPCConversation queststereo;
    public NPCConversation questbook;
    public NPCConversation questphoto;
    public NPCConversation questend;
    public NPCConversation questendloop;
    public NPCConversation prequest;

    public bool init = false;
    public bool complete = false;
    public bool hasbook = false;
    public bool hasstereo = false;
    public bool hasphoto = false;
    public bool endloop = false;

    public CoffeeMachine coffeePuzzle;

    public Pickup heldItem;

    // Start is called before the first frame update
    void Start()
    {
        heldItem = GameObject.Find("Main Camera").GetComponent<Pickup>();
    }

    public void Dialogue()
    {

        GameObject item = gameObject;
        if (heldItem.HeldName() != "none") item = heldItem.heldItem;

        if(!coffeePuzzle.puzzleComplete) ConversationManager.Instance.StartConversation(prequest);
        else if(!init)
        {
            ConversationManager.Instance.StartConversation(questinit);
            init = true;
        }
        else if(!complete && item.name == "Book")
        {
            ConversationManager.Instance.StartConversation(questbook);
            hasbook = true;
            Destroy(item);
            CheckComplete();
        }
        else if (!complete && item.name == "Stereo")
        {
            ConversationManager.Instance.StartConversation(queststereo);
            hasstereo = true;
            Destroy(item);
            CheckComplete();
        }
        else if (!complete && item.name == "Photo")
        {
            ConversationManager.Instance.StartConversation(questphoto);
            hasphoto = true;
            Destroy(item);
            CheckComplete();
        }
        else if(!complete)
        {
            ConversationManager.Instance.StartConversation(questloop);
        }
        else if(!endloop)
        {
            ConversationManager.Instance.StartConversation(questend);
            endloop = true;
        }
        else
        {
            ConversationManager.Instance.StartConversation(questendloop);
        }
    }

    public void CheckComplete()
    {
        if (hasbook && hasphoto && hasstereo)
        {
            complete = true;
            GameManager gm = GameObject.Find("GameManager").GetComponent<GameManager>();
            gm.movingComplete = true;
            gm.memoriesComplete++;
        }
    }
}

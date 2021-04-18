using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ConversationTrigger : MonoBehaviour
{
    public NPCConversation initConvo;
    public NPCConversation loopConvo;
    bool init = false;

    public bool needsCoffee = false;
    public bool hasOpenedPantry = false;
    public bool hasSeenHub = false;

    public MovingPuzzle movingPuzzle;

    private void OnMouseDown()
    {
        if (!GameObject.Find("GameManager").GetComponent<GameManager>().firstSpeech && (ConversationManager.Instance == null || !ConversationManager.Instance.IsConversationActive))
        {
            if (!init)
            {
                init = true;
                ConversationManager.Instance.StartConversation(initConvo);
                GameObject coffeePuzzle = GameObject.Find("CoffeePuzzle");
                coffeePuzzle.transform.GetChild(0).gameObject.SetActive(true);
                coffeePuzzle.transform.GetChild(1).gameObject.SetActive(true);
                coffeePuzzle.transform.GetChild(2).gameObject.SetActive(true);

            }
            else
            {
                ConversationManager.Instance.StartConversation(loopConvo);
                ConversationManager.Instance.SetBool("needCoffee", needsCoffee);
                ConversationManager.Instance.SetBool("visitedPantry", hasOpenedPantry);
                ConversationManager.Instance.SetBool("notVisitedHub", hasSeenHub);

                if(needsCoffee) GameObject.Find("DoorToGarage").GetComponent<Door>().locked = false;
            }
        }
        else
        {
            movingPuzzle.Dialogue();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Dad_Funeral: MonoBehaviour
{
    public NPCConversation initConvo;
    public NPCConversation loopConvo;

    public GameObject coffinPuzzle;

    public bool checkedCoffin = false;
    public bool doneCoffin = false;

    private void OnMouseDown()
    {
        ConversationManager.Instance.StartConversation(initConvo);

        /*if (ConversationManager.Instance == null || !ConversationManager.Instance.IsConversationActive)
        {
            if (!init)
            {
                init = true;
                
                
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

                if (needsCoffee) GameObject.Find("DoorToGarage").GetComponent<Door>().locked = false;
            }
        }
        else if (ConversationManager.Instance != null && ConversationManager.Instance.IsConversationActive)
        {

        }*/

    }

    // Start is called before the first frame update
    void Start()
    {
        coffinPuzzle = GameObject.Find("CoffinPuzzle");
    }

}

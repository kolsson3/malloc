using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Ash_Funeral : MonoBehaviour
{
    public NPCConversation initConvo;
    public NPCConversation loopConvo;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

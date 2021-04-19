
using UnityEngine;
using DialogueEditor;

public class BookConvoTrigger : MonoBehaviour
{
    public NPCConversation bookConvo;
    public GameObject thePortal;

    public GameObject oldText;
    public GameObject newText;

    bool triggered = false;

    void OnMouseDown()
    {
        if(!triggered)
        {
            thePortal.gameObject.SetActive(true);
            GameObject.Find("FrontDoor").GetComponent<Door>().locked = false;
            GameManager gm = GameObject.Find("GameManager").GetComponent<GameManager>();
            gm.memoriesComplete++;
            gm.birthdayComplete = true;
            triggered = true;
            ConversationManager.Instance.StartConversation(bookConvo);
        }
        
    }

    public void UpdateText()
    {
        oldText.SetActive(false);
        newText.SetActive(true);
    }
}

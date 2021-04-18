using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DialogueEditor;

public class GameManager : MonoBehaviour
{
    public string lastScene;
    public bool firstHubVisit = false;
    public bool firstSpeech = false;
    public bool secondSpeech = false;
    public bool thirdSpeech = false;
    public bool finalSpeech = false;

    public int memoriesComplete = 0;

    public bool tragedyComplete = false;
    public bool birthdayComplete = false;
    public bool movingComplete = false;
    public bool toUpdate = true;

    public Door tragedyDoor;
    public Door movingDoor;
    public Door birthdayDoor;

    public GameObject endCap1;
    public GameObject endCap2;

    void Awake()
    {
        GameObject[] managers = GameObject.FindGameObjectsWithTag("gamemanager");
        if (managers.Length > 1) Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Hub")
        {
            firstHubVisit = true;
            if (firstHubVisit && !firstSpeech) PlayFirstConvo();

            if (tragedyComplete) GameObject.Find("TragedyDoor").GetComponent<Door>().locked = true;
            if (movingComplete) GameObject.Find("MovingDoor").GetComponent<Door>().locked = true;
            if (birthdayComplete) GameObject.Find("BirthdayDoor").GetComponent<Door>().locked = true;

            if(memoriesComplete == 1 && !secondSpeech)
            {
                secondSpeech = true;
                //Call the next announcement when written
            }
            else if (memoriesComplete == 2 && !thirdSpeech)
            {
                thirdSpeech = true;
                //Call the next announcement when written

            }
            else if (memoriesComplete == 3 && !finalSpeech)
            {
                finalSpeech = true;
                //Call the next announcement when written

            }



            if (tragedyComplete && birthdayComplete && movingComplete)
            {
                GameObject end1 = GameObject.Find("Endcap1");
                if (end1) end1.SetActive(false);
                foreach (Transform child in GameObject.Find("Endcap2").transform)
                {
                    child.transform.gameObject.SetActive(true);
                }
            }

        }
        else if (SceneManager.GetActiveScene().name == "Memory1")
        {
            if (firstHubVisit)
            {
                GameObject.Find("ParentBedroomDoor").GetComponent<Door>().locked = false;
                GameObject coffeePuzzle = GameObject.Find("CoffeePuzzle");
                foreach(Transform child in coffeePuzzle.transform)
                {
                    child.transform.gameObject.SetActive(true);
                }
            }
        }
    }

    void PlayFirstConvo()
    {
        ConversationManager.Instance.StartConversation(GameObject.Find("FirstHubConvo").GetComponent<NPCConversation>());
        firstSpeech = true;
    }
}

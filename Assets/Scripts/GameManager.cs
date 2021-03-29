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

    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] managers = GameObject.FindGameObjectsWithTag("gamemanager");
        if (managers.Length > 1) Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Hub") firstHubVisit = true;
        if (firstHubVisit && !firstSpeech) PlayFirstConvo();
    }

    void PlayFirstConvo()
    {
        ConversationManager.Instance.StartConversation(GameObject.Find("FirstHubConvo").GetComponent<NPCConversation>());
        firstSpeech = true;
    }
}

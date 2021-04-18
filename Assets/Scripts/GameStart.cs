using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DialogueEditor;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{

    public NPCConversation introText;
    public Animator fade;
    public Image fadeScreen;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Fading());
        if (GameObject.Find("GameManager").GetComponent<GameManager>().lastScene == "")
        {
            ConversationManager.Instance.StartConversation(introText);
        }
        else if (SceneManager.GetActiveScene().name == "Memory3")
        {
            ConversationManager.Instance.StartConversation(introText);
        }
    }

    //Coroutine to play the fading animation
    IEnumerator Fading()
    {
        fade.SetBool("Fade", true);
        //Wait until fade to white is complete.
        yield return new WaitUntil(() => fadeScreen.color.a == 0);
        fade.SetBool("Fade", false);
        fade.StopPlayback();
        fadeScreen.gameObject.SetActive(false);
    }
}

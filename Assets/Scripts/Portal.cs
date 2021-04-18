using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{

    public string scene;
    void OnMouseDown()
    {
        if (SceneManager.GetActiveScene().name == "Memory1")
        {
            GameObject.Find("Character_Mother").GetComponent<ConversationTrigger>().hasSeenHub = true;
        }

        GameObject.Find("GameManager").GetComponent<GameManager>().lastScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(scene);
    }
}

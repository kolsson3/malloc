using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    private Queue<string> sentences;

    private GameObject mainCam;

    void Start()
    {
        sentences = new Queue<string>();
        mainCam = GameObject.Find("MainCamera");
    }

    public void StartDialogue(Dialogue dialogue)
    {
        mainCam.GetComponent<MystMovement>().inDialogue = true;
        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSencentece();
    }

    public void DisplayNextSencentece()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        
        string sentence = sentences.Dequeue();
        //dialogueText.text = sentence;
        string[] stringList = sentence.Split(':');
        nameText.text = stringList[0];
        StopAllCoroutines();
        StartCoroutine(TypeSentence(stringList[1]));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
    }

    void EndDialogue()
    {
        mainCam.GetComponent<MystMovement>().inDialogue = false;
        animator.SetBool("IsOpen", false);
    }
}

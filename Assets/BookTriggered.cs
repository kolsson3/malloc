using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookTriggered : MonoBehaviour
{
    public bool talkedToMom = false;
    public bool talkedToBetty = false;
    public GameObject associatedNode;
    public GameObject theBook;
    public GameObject thePortal;

    void Update()
    {
        if (talkedToBetty && talkedToMom)
        {
            theBook.gameObject.SetActive(true);
            associatedNode.gameObject.SetActive(true);
            thePortal.gameObject.SetActive(true);
        }
    }

    public void triggerBetty()
    {
        talkedToBetty = true;
    }

    public void triggerMom()
    {
        talkedToMom = true;
    }
}

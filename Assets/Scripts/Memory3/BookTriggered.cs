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

    public void triggerBetty()
    {
        talkedToBetty = true;
        CheckComplete();

    }

    public void triggerMom()
    {
        talkedToMom = true;
        CheckComplete();
    }

    public void CheckComplete()
    {
        if (talkedToBetty && talkedToMom)
        {
            theBook.gameObject.SetActive(true);
        }
    }
}

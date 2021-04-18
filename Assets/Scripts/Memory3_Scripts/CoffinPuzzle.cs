﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class CoffinPuzzle : MonoBehaviour
{
    public NPCConversation commentDone;
    public Pickup pickup;
    public GameObject placedFlowers;
    public GameObject placedPhoto;
    public GameObject placedCandle;
    public GameObject Flowers;
    public GameObject Photo;
    public GameObject Candle;
    public GameObject Dad;
    public GameObject Ash;
    public GameObject Portal;

    public bool solved = false;

    public bool checkedCoffin = false;

    public bool doneCandle = false;
    public bool donePhoto = false;
    public bool doneFlowers = false;

    public GameManager gm;

    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnMouseDown()
    {
        if (pickup.heldItem == Flowers)
        {
            placedFlowers.SetActive(true);
            Flowers.SetActive(false);
            doneFlowers = true;
            pickup.heldItem = null;
            checkSolved();
        }
        else if (pickup.heldItem == Candle)
        {
            placedCandle.SetActive(true);
            Candle.SetActive(false);
            doneCandle = true;
            pickup.heldItem = null;
            checkSolved();
        }
        else if (pickup.heldItem == Photo)
        {
            placedPhoto.SetActive(true);
            Photo.SetActive(false);
            donePhoto = true;
            pickup.heldItem = null;
            checkSolved();
        }

    }

    void checkSolved()
    {
        if (doneCandle == true && donePhoto == true && doneFlowers == true)
        {
            solved = true;
            ConversationManager.Instance.StartConversation(commentDone);
            Dad.SetActive(false);
            Ash.SetActive(false);
            Portal.SetActive(true);

            gm.memoriesComplete++;
            gm.tragedyComplete = true;
        }
    }
}

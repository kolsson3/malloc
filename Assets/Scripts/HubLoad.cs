using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubLoad : MonoBehaviour
{
    public GameManager gm;
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        GameObject mainCam = GameObject.Find("Main Camera");
        if (gm.lastScene == "Memory1")
        {
            mainCam.transform.position = GameObject.Find("MovingNode").transform.position;
            mainCam.GetComponent<Movement>().currentNode = GameObject.Find("MovingNode").GetComponent<CameraNode>();
        }


        if(gm.lastScene == "Hub")
        {
            mainCam.transform.position = GameObject.Find("PortalNode").transform.position;
            mainCam.GetComponent<Movement>().currentNode = GameObject.Find("PortalNode").GetComponent<CameraNode>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

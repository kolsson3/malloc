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
        else if (gm.lastScene == "Memory2")
        {
            mainCam.transform.position = GameObject.Find("BirthdayNode").transform.position;
            mainCam.GetComponent<Movement>().currentNode = GameObject.Find("BirthdayNode").GetComponent<CameraNode>();
        }
        else if (gm.lastScene == "Memory3")
        {
            mainCam.transform.position = GameObject.Find("TragedyNode").transform.position;
            mainCam.GetComponent<Movement>().currentNode = GameObject.Find("TragedyNode").GetComponent<CameraNode>();
        }
        else if (gm.lastScene == "Hub")
        {
            mainCam.transform.position = GameObject.Find("PortalNode").transform.position;
            mainCam.GetComponent<Movement>().currentNode = GameObject.Find("PortalNode").GetComponent<CameraNode>();
        }
    }
}

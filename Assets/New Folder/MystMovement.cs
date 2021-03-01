using UnityEngine;

public class MystMovement : MonoBehaviour
{
    public CameraNode currentNode;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 p = Input.mousePosition;

            if(currentNode.closeup && p.y < Screen.height/10)
            {
                Debug.Log("Backup");
                if (currentNode.closeup) currentNode.Backup();
            }else if (!currentNode.closeup && p.x < Screen.width/10)
            {
                Debug.Log("Turn Left");
                transform.Rotate(0f, -90f, 0f);
            }
            else if (!currentNode.closeup && p.x > Screen.width*0.9)
            {
                Debug.Log("Turn right");
                transform.Rotate(0f, 90f, 0f);
            }else
            {
                Debug.Log("Click at " + p.x + " and " + p.y);
            }
        }
    }

}

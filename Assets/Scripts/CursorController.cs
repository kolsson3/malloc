using UnityEngine;

public class CursorController : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    string tagHit;
    Movement mainCam;

    void Start()
    {
        mainCam = GameObject.Find("Main Camera").GetComponent<Movement>();
    }

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit)) tagHit = hit.collider.tag;
        if (tagHit == "NPC") Cursor.SetCursor(Resources.Load("conversation") as Texture2D, Vector2.zero, CursorMode.Auto);
        else if (Input.mousePosition.x > Screen.width * 0.9) Cursor.SetCursor(Resources.Load("right-arrow-symbol") as Texture2D, Vector2.zero, CursorMode.Auto);
        else if (Input.mousePosition.x < Screen.width / 10) Cursor.SetCursor(Resources.Load("back-arrow") as Texture2D, Vector2.zero, CursorMode.Auto);
        else if (tagHit == "Inspect") Cursor.SetCursor(Resources.Load("magnifier") as Texture2D, Vector2.zero, CursorMode.Auto);
        else if (tagHit == "Item") Cursor.SetCursor(Resources.Load("hand") as Texture2D, Vector2.zero, CursorMode.Auto);
        else if (tagHit == "Node") Cursor.SetCursor(Resources.Load("up-arrow") as Texture2D, Vector2.zero, CursorMode.Auto);
        else if (tagHit == "Unknown") Cursor.SetCursor(Resources.Load("question-sign") as Texture2D, Vector2.zero, CursorMode.Auto);
        else if (mainCam.currentNode.closeup && Input.mousePosition.y < Screen.height / 10) Cursor.SetCursor(Resources.Load("downward") as Texture2D, Vector2.zero, CursorMode.Auto);
        else Cursor.SetCursor(Resources.Load("cursor") as Texture2D, Vector2.zero, CursorMode.Auto);
    }
}

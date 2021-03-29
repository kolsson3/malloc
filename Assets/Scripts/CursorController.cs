using UnityEngine;

public class CursorController : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    string tag;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit)) tag = hit.collider.tag;
        if (tag == "NPC") Cursor.SetCursor(Resources.Load("conversation") as Texture2D, Vector2.zero, CursorMode.Auto);
        else if (tag == "Inspect") Cursor.SetCursor(Resources.Load("magnifier") as Texture2D, Vector2.zero, CursorMode.Auto);
        else if (tag == "Item") Cursor.SetCursor(Resources.Load("hand") as Texture2D, Vector2.zero, CursorMode.Auto);
        else if (tag == "Node") Cursor.SetCursor(Resources.Load("up-arrow") as Texture2D, Vector2.zero, CursorMode.Auto);
        else if (Input.mousePosition.x > Screen.width * 0.9) Cursor.SetCursor(Resources.Load("right-arrow-symbol") as Texture2D, Vector2.zero, CursorMode.Auto);
        else if (Input.mousePosition.x < Screen.width / 10) Cursor.SetCursor(Resources.Load("back-arrow") as Texture2D, Vector2.zero, CursorMode.Auto);
        else if (Input.mousePosition.y < Screen.height / 10) Cursor.SetCursor(Resources.Load("downward") as Texture2D, Vector2.zero, CursorMode.Auto);
        else Cursor.SetCursor(Resources.Load("cursor") as Texture2D, Vector2.zero, CursorMode.Auto);
    }
}

using UnityEngine;

public class GameExit : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
    }
}

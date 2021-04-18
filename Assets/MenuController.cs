using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Memory1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

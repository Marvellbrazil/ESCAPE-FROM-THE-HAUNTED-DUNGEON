using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void StartGame()
    {
        Time.timeScale = 1f; 
        // Load main menu Scene
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Reset time scale
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Game di-restart");
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}

using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public KeyCode quitKey = KeyCode.Escape;

    public void DoQuit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}

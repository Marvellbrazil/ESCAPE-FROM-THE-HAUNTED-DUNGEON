using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public AudioSource bgmSource;
    public AudioSource gameOverSource;
    
    public void TriggerGameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
        bgmSource.Stop();
        gameOverSource.Play();
    }
}

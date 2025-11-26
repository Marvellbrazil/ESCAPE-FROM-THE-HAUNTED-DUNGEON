using TMPro;
using UnityEngine;

public class KeyCollector : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject winPanel;

    private int collectedKeys = 0;
    private int totalKeys;

    void Start()
    {
        // Hitung semua buah di scene
        totalKeys = GameObject.FindGameObjectsWithTag("Key").Length;

        UpdateScoreText();
        winPanel.SetActive(false);
    }

    // Dipanggil dari script ExampleFruit ketika player mengambil buah
    public void CollectKeys()
    {
        collectedKeys++; // collectedKeys = collectedKeys +1
        UpdateScoreText();
        CheckWinCondition();
    }

    private void UpdateScoreText()
    {
        // update score text
        scoreText.text = "Keys: " + collectedKeys + " / " + totalKeys;
    }

    private void CheckWinCondition()
    {
        if (collectedKeys >= totalKeys)
        {
            // tampilkan win panel dan pause
            winPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}

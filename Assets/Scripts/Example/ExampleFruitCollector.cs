using TMPro;
using UnityEngine;

public class ExampleFruitCollector : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject winPanel;

    private int collectedFruits = 0;
    private int totalFruits;

    void Start()
    {
        // Hitung semua buah di scene
        totalFruits = GameObject.FindGameObjectsWithTag("Fruit").Length;

        UpdateScoreText();
        winPanel.SetActive(false);
    }

    // Dipanggil dari script ExampleFruit ketika player mengambil buah
    public void CollectFruit()
    {
        collectedFruits++; // collectedFruits = collectedFruits +1
        UpdateScoreText();
        CheckWinCondition();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Fruit: " + collectedFruits + " / " + totalFruits;
    }

    private void CheckWinCondition()
    {
        if (collectedFruits >= totalFruits)
        {
            winPanel.SetActive(true);
            Time.timeScale = 0f; // Pause game
        }
    }
}

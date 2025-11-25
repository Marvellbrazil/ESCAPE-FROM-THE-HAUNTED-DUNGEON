using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int startHealth = 3;
    public GameOver gameOver;
    public List<Image> heartImages;

    private int currentHealth;

    void Start()
    {
        currentHealth = startHealth;
    }

    public void DecreaseHealth(int amount)
    {
        // kurangi nyawa sesuai amount
        
        Image currentHeartImages = heartImages[currentHealth];
        currentHeartImages.gameObject.SetActive(false);
        if(currentHealth <= 0)
        {
            gameOver.TriggerGameOver();
        }
    }
}

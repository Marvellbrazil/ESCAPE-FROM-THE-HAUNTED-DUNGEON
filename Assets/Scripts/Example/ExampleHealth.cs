using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExampleHealth : MonoBehaviour
{
    public int startHealth = 3;
    public GameOver gameOver;
    public List<Image> heartImages;
    
    [Header("Player Info")]
    public SpriteRenderer playerSprite;
    public AudioSource damageSoundSource;
    public AudioClip damageSoundClip;

    private int currentHealth;

    void Start()
    {
        currentHealth = startHealth;
    }

    public void DecreaseHealth(int ammount)
    {
        currentHealth -= ammount;
        FlashRed();
        damageSoundSource.PlayOneShot(damageSoundClip);
        Image currentHeartImages = heartImages[currentHealth];
        currentHeartImages.gameObject.SetActive(false);
        if(currentHealth <= 0)
        {
            gameOver.TriggerGameOver();
        }
    }

    public void FlashRed()
    {
        StartCoroutine(FlashRedCoroutine());
    }

    private IEnumerator FlashRedCoroutine()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        Color originalColor = spriteRenderer.color;
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        spriteRenderer.color = originalColor;
    }
}

using UnityEngine;

public class Fruit : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    private bool isCollected = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isCollected)
        {
            isCollected = true;

            FruitCollector collector = other.GetComponent<FruitCollector>();
            if (collector != null)
            {
                collector.CollectFruit();
            }

            FeedbackOnCollect();

            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject, 0.3f);
        }
    }

    private void FeedbackOnCollect()
    {
        // Menambahkan efek suara
        audioSource.PlayOneShot(audioClip);
    }
}

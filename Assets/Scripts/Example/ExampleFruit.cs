using UnityEngine;

public class ExampleFruit : MonoBehaviour
{
    public AudioSource collectSoundSource;
    public AudioClip collectSoundClip;
    private bool isCollected = false; // Supaya tidak bisa diambil dua kali

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Pastikan hanya Player yang bisa mengambil
        if (other.CompareTag("Player") && !isCollected)
        {
            isCollected = true;

            // Panggil fungsi collect di script Player
            ExampleFruitCollector collector = other.GetComponent<ExampleFruitCollector>();
            if (collector != null)
            {
                collector.CollectFruit();
            }

            // Feedback visual
            FeedbackOnCollect();

            // Sembunyikan sprite & hancurkan setelah delay kecil
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject, 0.3f);
        }
    }

    private void FeedbackOnCollect()
    {
        // Menambahkan efek suara
        collectSoundSource.PlayOneShot(collectSoundClip);
    }
}

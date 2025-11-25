using UnityEngine;

public class Trap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ExampleHealth playerHealth = other.GetComponent<ExampleHealth>();
            playerHealth.DecreaseHealth(1);
        }
    }

}

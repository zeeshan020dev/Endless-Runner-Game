using UnityEngine;

public class Coin : MonoBehaviour
{
    private AudioManager audioManager;

    void Update()
    {
        // Rotates the coin 50 degrees per second around the X axis
        transform.Rotate(50 * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Use the static instance directly
            if (AudioManager.instance != null)
            {
                AudioManager.instance.PlaySound("PickUpCoin");
            }

            PlayerManager.numberofCoins += 1;
            Destroy(gameObject);
        }
    }
}
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        PlayerCoins player = other.GetComponentInParent<PlayerCoins>();

        if (player == null)
        {
            Debug.Log("PlayerCoins não encontrado!");
            return;
        }

        player.CollectCoin();

        Destroy(gameObject);
    }
}
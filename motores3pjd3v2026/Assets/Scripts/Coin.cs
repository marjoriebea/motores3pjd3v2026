using StarterAssets;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return; 
        
        PlayerObserverManager.NotifyCoinCollected();

        Destroy(gameObject);
    }
}
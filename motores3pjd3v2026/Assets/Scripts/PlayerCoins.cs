using UnityEngine;

public class PlayerCoins : MonoBehaviour
{
    private int coinCount = 0;

    public void CollectCoin()
    {
        coinCount++;

        PlayerObserverManager.NotifyCoinCountChanged(coinCount);
    }
}
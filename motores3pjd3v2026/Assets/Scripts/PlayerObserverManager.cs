using UnityEngine;
using System;

public class PlayerObserverManager : MonoBehaviour
{
    public static Action OnCoinCollected;
    public static Action<int> OnCoinCountChanged;

    public static int coinCount = 0;

    public static void NotifyCoinCollected()
    {
        coinCount++;

        OnCoinCollected?.Invoke();
        OnCoinCountChanged?.Invoke(coinCount);
    }
}
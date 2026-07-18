using System;
using UnityEngine;

public class PlayerObserverManager : MonoBehaviour
{
    public static Action OnCoinCollected;
    public static Action<int> OnCoinCountChanged;

    private static int coinCount = 0;

    public static void NotifyCoinCollected()
    {
        coinCount++;

        OnCoinCollected?.Invoke();
        OnCoinCountChanged?.Invoke(coinCount);
    }
}
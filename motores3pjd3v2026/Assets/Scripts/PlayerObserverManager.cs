using System;

public static class PlayerObserverManager
{
    public static Action<int> OnCoinCountChanged;

    public static void NotifyCoinCountChanged(int amount)
    {
        OnCoinCountChanged?.Invoke(amount);
    }
}
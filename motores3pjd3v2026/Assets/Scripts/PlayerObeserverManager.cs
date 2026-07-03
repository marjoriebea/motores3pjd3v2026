using System;

public static class PlayerObserverManager
{
    public static Action<int> AoColetarMoeda;

    public static void NotificarMoeda(int quantidade)
    {
        AoColetarMoeda?.Invoke(quantidade);
    }
}
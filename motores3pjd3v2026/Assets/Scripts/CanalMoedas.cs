using System;

public class CanalMoedas
{
    public event Action<int> AoColetarMoeda;

    public void Notificar(int totalMoedas)
    {
        AoColetarMoeda?.Invoke(totalMoedas);
    }
}
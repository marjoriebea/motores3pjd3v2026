using UnityEngine;

public class PlayerCoinCollector : MonoBehaviour
{
    private int quantidadeMoedas = 0;

    public void ColetarMoeda()
    {
        quantidadeMoedas++;

        PlayerObserverManager.CanalMoedas.Notificar(quantidadeMoedas);

        Debug.Log("Moedas: " + quantidadeMoedas);
    }
}
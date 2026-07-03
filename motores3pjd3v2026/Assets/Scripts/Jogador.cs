using UnityEngine;

public class Jogador : MonoBehaviour
{
    public static Jogador Instancia;

    public int moedas = 0;

    private void Awake()
    {
        Instancia = this;
    }

    public void AdicionarMoeda()
    {
        moedas++;

        PlayerObserverManager.NotificarMoeda(moedas);

        Debug.Log("Moedas: " + moedas);
    }
}
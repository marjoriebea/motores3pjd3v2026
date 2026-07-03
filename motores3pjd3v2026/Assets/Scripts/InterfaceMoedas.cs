using UnityEngine;
using TMPro;

public class InterfaceMoedas : MonoBehaviour
{
    public TMP_Text textoMoedas;

    private void OnEnable()
    {
        PlayerObserverManager.AoColetarMoeda += AtualizarTexto;
    }

    private void OnDisable()
    {
        PlayerObserverManager.AoColetarMoeda -= AtualizarTexto;
    }

    private void AtualizarTexto(int quantidade)
    {
        textoMoedas.text = "Moedas: " + quantidade;
    }
}
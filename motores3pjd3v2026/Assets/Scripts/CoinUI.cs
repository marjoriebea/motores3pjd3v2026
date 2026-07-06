using TMPro;
using UnityEngine;

public class CoinUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textoMoedas;

    private void OnEnable()
    {
        PlayerObserverManager.CanalMoedas.AoColetarMoeda += AtualizarTexto;
    }

    private void OnDisable()
    {
        PlayerObserverManager.CanalMoedas.AoColetarMoeda -= AtualizarTexto;
    }

    private void Start()
    {
        textoMoedas.text = "Moedas: 0";
    }

    private void AtualizarTexto(int totalMoedas)
    {
        textoMoedas.text = "Moedas: " + totalMoedas;
    }
}
using UnityEngine;

public class Moeda : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Jogador.Instancia.AdicionarMoeda();
            Destroy(gameObject);
        }
    }
}
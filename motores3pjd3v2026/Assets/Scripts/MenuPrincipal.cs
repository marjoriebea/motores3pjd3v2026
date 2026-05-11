using UnityEngine;

public class MenuPrincipal : MonoBehaviour
{
    public void IniciarJogo()
    {
        GameManager.Instancia.CarregarCena("Jogo");
    }

    public void Sair()
    {
        GameManager.Instancia.SairJogo();
    }
}
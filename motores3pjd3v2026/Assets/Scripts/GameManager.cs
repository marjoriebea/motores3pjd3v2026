using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem; // Importante para o novo Input System
using System.Collections;

// 1. Definição dos Estados
public enum GameState { Iniciando, MenuPrincipal, Gameplay }

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [Header("Configurações")]
    public GameState currentState;

    private void Awake()
    {
        // 2. Lógica de Singleton
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        // Ao iniciar no _Boot, começa a sequência
        StartCoroutine(SequenceIniciando());
    }

    // 3. Máquina de Estados Simples
    public void ChangeState(GameState newState)
    {
        currentState = newState;
        Debug.Log($"<color=cyan>[GameManager]</color> Estado Atual: <b>{currentState}</b>");
    }

    // 4. Controle Centralizado de Cenas
    public void ChangeScene(string sceneName)
    {
        // Regra de negócio: Só muda para Gameplay se vier do Menu
        if (sceneName == "GetStarted_Scene")
        {
            ChangeState(GameState.Gameplay);
            SceneManager.LoadScene(sceneName);
        }
        else if (sceneName == "MenuPrincipal")
        {
            ChangeState(GameState.MenuPrincipal);
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    // Coroutine para a Splash
    private IEnumerator SequenceIniciando()
    {
        ChangeState(GameState.Iniciando);
        SceneManager.LoadScene("SplashScene");
        
        yield return new WaitForSeconds(2f); // Espera os 2 segundos solicitados
        
        ChangeScene("MenuPrincipal");
    }

    // 5. Alocação de Input
    public void SetupPlayerInput(PlayerInput playerInput)
    {
        if (playerInput != null)
        {
            // Aqui você garante que o input só funciona se estiver em Gameplay
            playerInput.enabled = (currentState == GameState.Gameplay);
            Debug.Log("Input alocado ao jogador.");
        }
    }

    public void QuitGame()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}
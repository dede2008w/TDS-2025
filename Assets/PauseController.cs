using UnityEngine;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{
    [SerializeField] public GameObject pauseMenuPrefab; // Prefab do menu de pause
    private GameObject pauseMenuInstance;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (!isPaused)
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        // Pausa o tempo
        Time.timeScale = 0f;

        // Instancia o prefab do menu de pause
        pauseMenuPrefab.SetActive(true);

        // Procura o botão "Resume" dentro do prefab e adiciona um listener para ResumeGame()
        Button resumeButton = pauseMenuPrefab.GetComponentInChildren<Button>();
        if (resumeButton != null)
        {
            resumeButton.onClick.AddListener(ResumeGame);
        }

        isPaused = true;
    }

    public void ResumeGame()
    {
       
        // Retoma o tempo
        Time.timeScale = 1f;
        pauseMenuPrefab.SetActive(false);

        // Destroi o menu de pause
      

        isPaused = false;
    }
}

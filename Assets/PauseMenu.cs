using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [Header("Painel de pausa")]
    public GameObject panel;

    private bool isPaused = false;

    void Start()
    {
        if (panel != null)
        {
            panel.SetActive(false);
        }

        Time.timeScale = 1f;
        isPaused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1) && !isPaused)
        {
            PauseGame();
        }
    }

    public void ResumeGame()
    {
        if (panel == null) return;

        isPaused = false;
        panel.SetActive(false);
        Time.timeScale = 1f;
    }

    private void PauseGame()
    {
        if (panel == null) return;

        isPaused = true;
        panel.SetActive(true);
        Time.timeScale = 0f;
    }
}

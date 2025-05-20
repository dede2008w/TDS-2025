using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCena : MonoBehaviour
{
    public string Play;

    public void CarregarCena()
    {
        SceneManager.LoadScene(Play);
    }
}
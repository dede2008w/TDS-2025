using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCena : MonoBehaviour
{
    public string a;

    public void CarregarCena()
    {
        SceneManager.LoadScene(a);
        
    }
}
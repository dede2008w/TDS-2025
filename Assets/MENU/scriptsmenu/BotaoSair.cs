using UnityEngine;

public class BotaoSair : MonoBehaviour
{
    // Este método deve ser chamado pelo botão ao clicar
    public void FecharJogo()
    {
        Debug.Log("Fechando o jogo...");
        Application.Quit();
    }
}

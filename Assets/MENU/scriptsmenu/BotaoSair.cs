using UnityEngine;

public class BotaoSair : MonoBehaviour
{
    // Este m�todo deve ser chamado pelo bot�o ao clicar
    public void FecharJogo()
    {
        Debug.Log("Fechando o jogo...");
        Application.Quit();
    }
}

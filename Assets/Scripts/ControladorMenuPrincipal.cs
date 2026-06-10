using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMenuPrincipal : MonoBehaviour
{
    public void BTN_Jogar()
    {
        SceneManager.LoadScene("SCN_Level_01");
    }

    public void BTN_Sair()
    {
        // Forma correta que funciona tanto no editor quanto no jogo finalizado
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }

    public void BTN_Creditos()
    {
        // Certifique-se de que a sua cena de créditos tem exatamente este nome de arquivo: SCN_Creditos
        SceneManager.LoadScene("SCN_Creditos");
    }
}

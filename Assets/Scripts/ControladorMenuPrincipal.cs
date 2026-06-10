using UnityEditor;
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
        EditorApplication.ExitPlaymode();
    }

    public void BTN_Creditos()
    {
        SceneManager.LoadScene("SCN_Creditos");
    }

    public void BTN_Menu()
    {
        SceneManager.LoadScene("SCN_MenuPrincipal");
    }

}

using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorBotãoCreditos : MonoBehaviour
{
    
    public void BTN_Menu()
    {
        SceneManager.LoadScene("SCN_MenuPrincipal");
    }

}
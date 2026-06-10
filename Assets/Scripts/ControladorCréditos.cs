using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorCreditos : MonoBehaviour
{
    
    public void BTN_Voltar()
    {
        SceneManager.LoadScene("SCN_MenuPrincipal");
    }
}

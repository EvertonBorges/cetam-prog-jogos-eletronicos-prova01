using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class voltarpromenu : MonoBehaviour
{
    
    public void BTN_VOLTAR()
    {
        SceneManager.LoadScene("SCN_MenuPrincipal");
    }

}

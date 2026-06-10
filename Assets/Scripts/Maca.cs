using System.Security.AccessControl;
using UnityEngine;




public class Maca : MonoBehaviour
{

    public ControladorMacas controladorUIMacas;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            controladorUIMacas.AdicionaMaca();
            Destroy(gameObject);
            
        }
    }
    
}

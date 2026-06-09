using UnityEngine;

public class Maca : MonoBehaviour
{

    public ControladorMacas controladorUIMacas;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
    
}

using UnityEngine;

public class Maca : MonoBehaviour
{

    public ControladorMacas controladorUIMacas;
    public AudioSource audioSource;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            controladorUIMacas.AdicionaMaca();
            Destroy(gameObject);
            audioSource.Play();            
        }
    }
    
}

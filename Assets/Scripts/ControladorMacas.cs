using TMPro;
using UnityEngine;
using UnityEngine.Audio;



public class ControladorMacas : MonoBehaviour
{
    public AudioSource audioSource;

    public TextMeshProUGUI texto;

    private int macas = 0;

    public void AdicionaMaca()
    {
        macas++;
        texto.SetText(macas.ToString());
        audioSource.Play();

    }

}

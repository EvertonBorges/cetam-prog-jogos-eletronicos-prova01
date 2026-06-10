using TMPro;
using UnityEngine;

public class ControladorMacas : MonoBehaviour
{
    public TextMeshProUGUI texto;
    private int macas = 0;

    void Start()
    {
        // Começa mostrando o valor inicial da variável (0)
        texto.SetText(macas.ToString());
    }

    public void AdicionaMaca()
    {
        macas++;
        texto.SetText(macas.ToString());
    }
}
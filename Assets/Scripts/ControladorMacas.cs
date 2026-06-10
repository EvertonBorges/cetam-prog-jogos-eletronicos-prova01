using TMPro;
using UnityEngine;

public class ControladorMacas : MonoBehaviour
{

    public TextMeshProUGUI texto;

    private int macas = 0;
    void Start()
    {
       texto.SetText("5");
    }
    public void AdicionaMaca()
    {
        macas++;
        texto.SetText(macas.ToString());
    }

}

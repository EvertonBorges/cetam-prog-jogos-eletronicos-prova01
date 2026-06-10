using TMPro;
using UnityEngine;

public class ControladorMacas : MonoBehaviour
{

    public TextMeshProUGUI texto;

     int macas = 0;

    
    void Start()
    {
         texto.SetText("0");
    }
    public void AdicionaMaca()
    {
        macas++;
        texto.SetText(""+macas);
    }

}

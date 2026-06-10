using TMPro;
using UnityEngine;

public class ControladorMacas : MonoBehaviour
{

    public TextMeshProUGUI text;

     int macas = 0;
    void Start()
    {
        text.SetText("5");
    }
    public void AdicionaMaca()
    {
        macas++;
        text.SetText(""+ macas);
    }

}

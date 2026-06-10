using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControladorMacas : MonoBehaviour
{

    public TextMeshProUGUI text;
    private int macas = 0;
    public void AdicionaMaca()
    {
        macas++;
        text.SetText(macas.ToString());

    }

}

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControladorMacas : MonoBehaviour
{

    public TextMeshProUGUI text;

    int macas = 0;

    void Start()
    {
        text.SetText("0");
    }

    public void AdicionaMaca()
    {
        macas++;
        text.SetText("" + macas);
    }

}
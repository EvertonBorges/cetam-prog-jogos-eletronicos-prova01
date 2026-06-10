using TMPro;
using UnityEngine;

public class ControladorMacas : MonoBehaviour
{

    public TextMeshProUGUI texto;

    int macas = 0;
    void Start()
    {
       texto.SetText("18");
    }
    public void MacaColetada()
    {
        macas++;
        texto.SetText(""+ macas);
    }

}

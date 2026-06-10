using TMPro;
using UnityEngine;

public class ControladorMacas : MonoBehaviour
{

    public TextMeshProUGUI contadorTexto;

    private int macas = 0;

    void Start()
    {
        contadorTexto.text = "macas = 0";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Maca"))
        {
            macas++;
            Destroy(collision.gameObject);
        }
    }

    public void AdicionaMaca()
    {
        macas++;
        contadorTexto.SetText(macas.ToString());
    }

}

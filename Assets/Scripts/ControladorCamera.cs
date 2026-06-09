using UnityEngine;

public class ControladorCamera : MonoBehaviour
{

    public Transform alvo;

    private void Update()
    {
        var position = transform.position;
        position.x = alvo.position.x;
        
        transform.position = position;
    }
    
}

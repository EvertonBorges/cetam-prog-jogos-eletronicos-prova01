using UnityEngine;

public class ControladorBackground : MonoBehaviour
{
    
    public SpriteRenderer sprite;
    public Vector2 velocidadeOffset = Vector2.zero;

    private Vector2 offset = Vector2.zero;
    private Material material;

    void Start()
    {
        material = sprite.material;
    }

    void Update()
    {
        offset += velocidadeOffset * Time.deltaTime;
        material.SetTextureOffset("_BaseMap", offset);
    }

}

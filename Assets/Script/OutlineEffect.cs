using UnityEngine;

public class OutlineEffect : MonoBehaviour
{
    public Material outlineMaterial;

    private Material originalMaterial;
    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        originalMaterial = renderer.material;
    }

    public void EnableOutline()
    {
        renderer.material = outlineMaterial;
    }

    public void DisableOutline()
    {
        renderer.material = originalMaterial;
    }
}

using UnityEngine;

public class TrailRendererController : MonoBehaviour
{
    public TrailRenderer trailRenderer;
    public MaterialPersonalizado materialPersonalizado;

    private void Start()
    {

        trailRenderer.startWidth = 0.1f;
        trailRenderer.endWidth = 0.1f;
        trailRenderer.startColor = Color.red;
        trailRenderer.endColor = Color.red;
        trailRenderer.material = materialPersonalizado.Material;

        Invoke("CambiarConfiguracion1", 2);
    }

    private void CambiarConfiguracion1()
    {
        trailRenderer.startWidth = 0.2f;
        trailRenderer.endWidth = 0.2f;
        trailRenderer.startColor = Color.blue;
        trailRenderer.endColor = Color.green;
        trailRenderer.material = materialPersonalizado.Material;
        materialPersonalizado.colorBase = Color.blue;
        materialPersonalizado.brillo = 0.5f;
        materialPersonalizado.rugosidad = 0.2f;
        materialPersonalizado.ActualizarPropiedades();

        Invoke("CambiarConfiguracion2", 2);
    }
}
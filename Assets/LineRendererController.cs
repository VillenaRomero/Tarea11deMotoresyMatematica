using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererController : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public MaterialPersonalizado materialPersonalizado;

    private void Start()
    {
        lineRenderer.startColor = Color.red;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, transform.position + Vector3.forward * 10);
    }

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            lineRenderer.SetPosition(1, hit.point);
            materialPersonalizado.colorBase = Color.blue;
            materialPersonalizado.brillo = 0.5f;
            materialPersonalizado.rugosidad = 0.2f;
            materialPersonalizado.ActualizarPropiedades();
        }
        else
        {
            lineRenderer.SetPosition(1, transform.position + Vector3.forward * 10);
            materialPersonalizado.colorBase = Color.red;
            materialPersonalizado.brillo = 0.8f;
            materialPersonalizado.rugosidad = 0.5f;
            materialPersonalizado.ActualizarPropiedades();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientodetubodeabajo : MonoBehaviour
{
    // Referencia al Rigidbody del objeto
    private Rigidbody rb;

    // Velocidad de movimiento hacia abajo
    public float velocidadX = 5.0f;

    void Awake()
    {
        // Obtener la referencia al Rigidbody en el momento de inicialización
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // Establecer la velocidad del objeto hacia abajo
        rb.velocity = new Vector3( -velocidadX,0, 0);
    }
}

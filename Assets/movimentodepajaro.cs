using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDePajaro : MonoBehaviour
{
    private Rigidbody rb;

    public float fuerzaImpulsoArriba = 10.0f;
    public float fuerzaImpulsoAbajo = 5.0f;
    public float velocidadRotacionMaxima = 100.0f;
    public float factorRotacionMomentum = 0.1f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * fuerzaImpulsoArriba, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.down * fuerzaImpulsoAbajo, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        float velocidadVertical = rb.velocity.y;
        float rotacion = velocidadVertical * factorRotacionMomentum;
        rotacion = Mathf.Clamp(rotacion, -velocidadRotacionMaxima, velocidadRotacionMaxima);
        transform.rotation = Quaternion.Euler(0, 0, rotacion);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Tuberia")
        {
                rb.AddForce(new Vector3(-5.0f, -2.0f, 0), ForceMode.Impulse);
        }
        if (collision.gameObject.tag == "LimitesCamara")
        {
            Destroy(this.gameObject);
        }
      
    }
}
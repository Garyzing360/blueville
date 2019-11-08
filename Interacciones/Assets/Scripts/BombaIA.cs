using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombaIA : MonoBehaviour
{
    public float velocidadCaida;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector3(0.0f, -2.0f, 0.0f) * velocidadCaida;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public int vida;
    public float velocidad;
    public float xMin, xMax;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   if (vida <= 0)
        {
            Destroy(gameObject, 0f);
        }

    }

    private void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, 0.0f);
        rb.velocity = movimiento * velocidad;
        rb.position = new Vector3(Mathf.Clamp(rb.position.x, xMin, xMax), -3.141f, 0.0f);

    }

    private void OnTriggerEnter2D(Collider2D Colisiones)
    {
        if (Colisiones.CompareTag("Bomba"))
        {
            vida = vida - 1;
            Debug.Log(vida);
        }
    }
}

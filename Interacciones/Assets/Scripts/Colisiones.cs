using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D Colisiones)
    {
        if (Colisiones.CompareTag("Player") || Colisiones.CompareTag("Floor"))
        {
            Destroy(gameObject, 0f);
        }
    }

}

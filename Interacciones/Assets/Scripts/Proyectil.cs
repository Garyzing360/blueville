using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public GameObject proyectil;
    public Vector3 spawnAtaque;
    public int cuentaBombas;
    public float spawn;
    public float StartWave;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWave());
    }

    IEnumerator SpawnWave() 
    {
        yield return new WaitForSeconds(StartWave);
        while (true) {
            for (int i = 0; i < cuentaBombas; i++ )
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnAtaque.x, spawnAtaque.x), spawnAtaque.y, spawnAtaque.z);
                Quaternion spawnRotacion = Quaternion.identity;
                Instantiate(proyectil, spawnPosition, spawnRotacion);
                yield return new WaitForSeconds(spawn);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

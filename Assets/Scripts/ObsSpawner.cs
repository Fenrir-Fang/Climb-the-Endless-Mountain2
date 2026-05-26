using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsSpawner : MonoBehaviour
{
    //[SerializeField] GameObject Obstaculo;
    [SerializeField] GameObject [] Obstaculos; //Agrega multiples game objects
    [SerializeField] float tiempoEntreSpawns = 1.5f;
    [SerializeField] float minX = -8f;
    [SerializeField] float MasX = 8f;
    [SerializeField] float alturaExtra = 6f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarObstaculo", 0f, tiempoEntreSpawns);

    }

    // Update is called once per frame
    void GenerarObstaculo()
    {
        float posicionX = Random.Range(minX, MasX);
        Vector2 posicionSpawn = new Vector2(posicionX, transform.position.y + alturaExtra);


        GameObject obstaculoRandom = Obstaculos[Random.Range(0, Obstaculos.Length)];
        Instantiate(obstaculoRandom, posicionSpawn, Quaternion.identity);
        //Instantiate(DifficultManager.instance.TrampaActual, posicionSpawn, Quaternion.identity);
        // Crea el objeto en la escena
        //Instantiate(Obstaculo, posicionSpawn, Quaternion.identity);
    }
}

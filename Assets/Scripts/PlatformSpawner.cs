using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] GameObject ObjPrefab;
    [SerializeField] GameObject PlataformaCabra;
    [SerializeField] GameObject TierraSuelta;
    //[SerializeField] GameObject [] FakePlatform;
    [SerializeField] Transform Player;
    [SerializeField] float minX = -8f;
    [SerializeField] float MasX = 8f;


    //[SerializeField] float time = 1f;

    [SerializeField] float distanciaEntrePlataformas = 3f;

    float recordaltura = 0f;

    [SerializeField] float separacionMinima = 2f;
    [SerializeField] int cantidadPlataformas = 2;

    [Range(0,100)]
    [SerializeField] int porcentajeFalso = 10;
    // Start is called before the first frame update
    void Start()
    {
        if (Player != null) 
        {
            recordaltura = Player.position.y;

            StartCoroutine(ControlAltura());
        }
        //InvokeRepeating("SpawnObject", 0f, time);
    }

    IEnumerator ControlAltura()
    {
        while (true)
        {
            if (Player.position.y > recordaltura)
            {
                SpawnObject();

                recordaltura += distanciaEntrePlataformas;
            }

            yield return null; // revisa cada frame
        }
    }

    void SpawnObject()
    {
        float ultimaX = 999f;

        for (int i = 0; i < cantidadPlataformas; i++) // genera 2 plataformas
        {
            float randomX;
            // Genera una posición aleatoria que no esté muy cerca del centro
            do
            {
                randomX = Random.Range(minX, MasX);
            }
            while (Mathf.Abs(randomX - ultimaX) < separacionMinima); //(Mathf.Abs(randomX) < separacionMinima);

            ultimaX = randomX;
            float randomY = Random.Range(0f, 3f);

            Vector2 spawnPosition = new Vector2(randomX, transform.position.y + randomY);

            //Instantiate(DifficultManager.instance.plataformActual, spawnPosition, Quaternion.identity);

            int random = Random.Range(0, 100);

            GameObject plataformaGenerada;

            if (random < DifficultManager.instance.porcentajePlataformaCabra)//(random < DifficultManager.instance.porcentajeActual)
            {
                plataformaGenerada = PlataformaCabra;
                //int indice = Random.Range(0, FakePlatform.Length);

                //plataformaGenerada = FakePlatform[indice];
            }
            else if(random < DifficultManager.instance.porcentajePlataformaCabra + DifficultManager.instance.porcentajeTierraSuelta)
            {
                plataformaGenerada = TierraSuelta;
            }
            else 
            {
                plataformaGenerada = DifficultManager.instance.plataformActual;
            }

            Instantiate(plataformaGenerada, spawnPosition, Quaternion.identity);
            //Instantiate(ObjPrefab, spawnPosition, Quaternion.identity);
        }

    }
    void Update()
    {
        
    }
}

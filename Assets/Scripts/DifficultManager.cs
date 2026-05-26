using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultManager : MonoBehaviour
{
    public static DifficultManager instance;

    [SerializeField] Transform player;

    [Header("Plataform")]

    public GameObject plataformActual;

    [SerializeField] GameObject Plataforma2;

    [SerializeField] GameObject Plataforma3;

    [SerializeField] GameObject Plataform4;

    //[Header("Trampas")]

    //public GameObject TrampaActual;

    //[SerializeField] GameObject Trampas;

    //[SerializeField] CameraFollow camara;
    //[SerializeField] Altura alturaUI;


    //float maxHigh;
    //[System.Serializable]

    //public class Heights
    //{
    //    public float height;

    //    public float SpawnRate;

    //    public GameObject player;
    //}

    //[SerializeField] float height1;

    //[SerializeField] float height4 = 20.5f;
    //[SerializeField] GameObject player4;
    [Header("Alturas")]

    [SerializeField] float height2 = 10.0f;
    [SerializeField] float height3 = 20.5f;
    //[SerializeField] float AlturaTramp = 30f;

     void Awake()
    {
        instance = this;
    }

    void Start() 
    {
        plataformActual = Plataforma2;

        StartCoroutine(ControlDificultad());
    }
    IEnumerator ControlDificultad()
    {
        while (true) 
        {
            float altura = player.position.y;
            
            if (altura >= height2)
            {
                plataformActual = Plataforma3;

            }

            if (altura >= height3)
            {
                plataformActual = Plataform4;

                //TrampaActual = Trampas;
            }

            yield return null;
        }

    }

}

//Debug.Log(player.position.y);

//while (player.position.y < height2)
//{
//    yield return null;
//}


//GameObject oldPlayer = player.gameObject;
//GameObject newPlayer = Instantiate(player2);//No copiar el GameObject
//newPlayer.transform.position = player.position;
//player = newPlayer.transform;
//camara.target = player;
//alturaUI.player = player;
//Destroy(oldPlayer);


//while (player.position.y < height3)
//{
//    yield return null;
//}

//oldPlayer = player.gameObject;
//newPlayer = Instantiate(player3);//No copiar el GameObject
//newPlayer.transform.position = player.position;
//player = newPlayer.transform;
//camara.target = player;
//alturaUI.player = player;
//Destroy(oldPlayer);



//while (player.position.y < height4)
//{
//    yield return null;
//}

//oldPlayer = player.gameObject;
//newPlayer = Instantiate(player4);//No copiar el GameObject
//newPlayer.transform.position = player.position;
//player = newPlayer.transform;
//camara.target = player;
//alturaUI.player = player;
//Destroy(oldPlayer);

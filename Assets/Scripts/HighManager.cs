using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighManager : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] CameraFollow camara;
    [SerializeField] Altura alturaUI;

    float maxHigh;
    [System.Serializable]

    public class Heights
    {
        public float height;

        public GameObject player;
    }

    [SerializeField] float height1;
    [SerializeField] GameObject player1;
    [SerializeField] float height2 = 5.0f;
    [SerializeField] GameObject player2;
    [SerializeField] float height3 = 10.5f;
    [SerializeField] GameObject player3;
    [SerializeField] float height4 = 20.5f;
    [SerializeField] GameObject player4;

    // Update is called once per frame
    IEnumerator Start()
    {
        Debug.Log(player.position.y);
        
        while (player.position.y < height2)
        {
            yield return null;
        }
        GameObject oldPlayer = player.gameObject;
            GameObject newPlayer = Instantiate(player2);//No copiar el GameObject
        newPlayer.transform.position = player.position;
        player = newPlayer.transform;
        camara.target = player;
        alturaUI.player = player;
            Destroy(oldPlayer);


        while (player.position.y < height3)
        {
            yield return null;
        }

        oldPlayer = player.gameObject;
         newPlayer = Instantiate(player3);//No copiar el GameObject
        newPlayer.transform.position = player.position;
        player = newPlayer.transform;
        camara.target = player;
        alturaUI.player = player;
        Destroy(oldPlayer);



        while (player.position.y < height4)
        {
            yield return null;
        }

        oldPlayer = player.gameObject;
        newPlayer = Instantiate(player4);//No copiar el GameObject
        newPlayer.transform.position = player.position;
        player = newPlayer.transform;
        camara.target = player;
        alturaUI.player = player;
        Destroy(oldPlayer);

    }




}

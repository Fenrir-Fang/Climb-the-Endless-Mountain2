using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Vector2 currentCheckpoint;
    [SerializeField] Transform Startpoint;

    private void Start()
    {
        currentCheckpoint = Startpoint.position;
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }

    }

    public void UpdateCheckPoint(Vector2 newpos)
    {
        currentCheckpoint = newpos;
    }


}

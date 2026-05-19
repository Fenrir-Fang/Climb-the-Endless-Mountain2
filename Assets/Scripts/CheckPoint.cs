using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            GameManager.instance.UpdateCheckPoint(transform.position);

            Vector2 checkpointPos =
    new Vector2(
        transform.position.x,
        transform.position.y + 1f
    );

            GameManager.instance.UpdateCheckPoint(checkpointPos);
        }
    }
}

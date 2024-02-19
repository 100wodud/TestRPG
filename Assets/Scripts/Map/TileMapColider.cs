using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMapColider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Game Over");
            Destroy(collision.gameObject);
        }
    }
}

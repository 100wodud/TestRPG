using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMapColider : MonoBehaviour
{
    public GameObject Gameover;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Time.timeScale = 0f;
            Instantiate(Gameover);
        }
    }
}

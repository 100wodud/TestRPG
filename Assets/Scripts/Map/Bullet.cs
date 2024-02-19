using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    private void Update()
    {
        Vector3 curPos = transform.position;
        Vector3 nextPos = Vector3.left * bulletSpeed * Time.deltaTime;
        transform.position = curPos + nextPos;
        if (transform.position.x < -20f)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Game Over");
            Destroy(collision.gameObject);
        }
    }
}

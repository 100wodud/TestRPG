using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject[] colliderObjs;
    public Transform[] spawnPoints;

    public float maxSpawnDelay;
    public float curSpawnDelay;
    public float spawnDelay;

    int level = 0;

    public float Score;

    void Update()
    {
        curSpawnDelay += Time.deltaTime;
        Score += Time.deltaTime * 10;

        
        if(curSpawnDelay > maxSpawnDelay)
        {
            SpawnCollider();
            maxSpawnDelay = Random.Range(0.5f, spawnDelay);
            curSpawnDelay = 0f;
        }

        if((int)Score / 100 > level)
        {
            level = (int)Score / 100;
            InvokeRepeating("SpawnBullet", 5f, level);
            spawnDelay -= 0.5f;

            if(spawnDelay < 1.5f)
            {
                spawnDelay = 1.5f;
            }
        } 

    }

    void SpawnCollider()
    {
        int ranCollider = Random.Range(0, 2);
        int ranPoint = Random.Range(0, 5);

        Instantiate(colliderObjs[ranCollider], spawnPoints[ranPoint].position, spawnPoints[ranPoint].rotation);
    }

    void SpawnBullet()
    {
        float randX = 20f;
        float randY = Random.Range(-4 , 4);
        transform.position = new Vector3(randX, randY, 0);

        Instantiate(Bullet, transform.position, transform.rotation);

    }
}

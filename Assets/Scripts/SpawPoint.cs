using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawPoint : MonoBehaviour
{
    [SerializeField]
    GameObject enemy;
    [SerializeField]
    float maxSpawnTime;
    float spawnTimer;
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = maxSpawnTime / 2;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if(spawnTimer <= 0)
        {
            Instantiate(enemy, transform.position, transform.rotation);
            spawnTimer = maxSpawnTime - Random.Range(0f, 4f);
        }
    }
}

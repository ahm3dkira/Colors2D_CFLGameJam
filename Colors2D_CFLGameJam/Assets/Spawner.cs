using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float startTimetoSpawn;
    private float timeBtSpawn;
    public GameObject[] enemies;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // TODO idk
        if (timeBtSpawn <= 0)
        {
            Instantiate(enemies[Random.Range(0, enemies.Length)], transform.position, Quaternion.identity);
            timeBtSpawn = startTimetoSpawn;
        }else
        {
            timeBtSpawn -= Time.deltaTime;
        }
    }
}

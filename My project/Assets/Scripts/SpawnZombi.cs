using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombi : MonoBehaviour
{
    [SerializeField] GameObject[] Zombie1_Prefab;
    [SerializeField] Transform[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnear", 0.1f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Spawnear()
    {
        int i = Random.Range(0, 4);
        int s = Random.Range(0, 6);
        Instantiate(Zombie1_Prefab[i], spawnPoints[s].position, Quaternion.identity);
    }
}
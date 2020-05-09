using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnable;
    public float rate = 1f;
    public float variance = 0.5f;

    public GameObject edgeA;
    public GameObject edgeB;

    private float lastSpawn = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lastSpawn += Time.deltaTime;
        float spawnVariance = Random.Range(-variance, variance);

        if (lastSpawn + spawnVariance > rate) {
            Vector3 spawnPoint = Vector3.Lerp(edgeA.transform.position, edgeB.transform.position, Random.value);
            Instantiate(spawnable, spawnPoint, Quaternion.identity);
            lastSpawn = 0f;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Hazard))]
[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Fall))]
public class Asteroid : MonoBehaviour
{
    public GameObject clone;
    public int generation = 1;
    public float spawnDistance = 1f;
    private Hazard hazard;
    // Start is called before the first frame update
    void Start()
    {
        hazard = GetComponent<Hazard>();
        hazard.health = generation;
        hazard.scoreAwarded = generation == 1 ? 1 : 0;
        hazard.maxHealth = generation;
        transform.localScale = Vector3.one * generation * 2;
        spawnDistance = generation * 1.2f;
    }

    private Vector2 getRandomVector()
    {
        return new Vector2(Random.value, Random.value).normalized;
    }

    public void OnDie()
    {
        if (generation > 1)
        {
            Vector3 position = getRandomVector() * spawnDistance;
            GameObject CloneA = Instantiate(clone, transform.position + position, Quaternion.identity);
            GameObject CloneB = Instantiate(clone, transform.position - position, Quaternion.identity);
            CloneA.GetComponent<Asteroid>().generation = this.generation - 1;
            CloneB.GetComponent<Asteroid>().generation = this.generation - 1;
        }
    }
}

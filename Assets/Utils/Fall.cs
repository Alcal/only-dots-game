using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Fall : MonoBehaviour
{
    public float fallSpeed = 1f;
    public float variance = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        float speed = Random.Range(fallSpeed-variance, fallSpeed+variance);
        GetComponent<Rigidbody2D>().velocity = new Vector3(0f, -speed, 0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToLive : MonoBehaviour
{
    public float life = 1f;

    private float startTime;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("halp");
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime > life) {
            Destroy(gameObject);
        }
    }
}

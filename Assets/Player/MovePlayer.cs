using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public PlayerStats stats;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 translation =
            new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        GetComponent<Rigidbody2D>().velocity = translation.normalized * stats.speed;
    }
}

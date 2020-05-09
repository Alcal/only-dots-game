using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ship : MonoBehaviour
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.ToLower() == "hazard")
        {
            stats.health--;
            GetComponent<Rigidbody2D>().AddForce(collision.GetContact(0).normal * 10000);
        }
    }
}

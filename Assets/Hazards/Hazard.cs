using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(InterpolateColor))]
[RequireComponent(typeof(FlashColor))]
public class Hazard : MonoBehaviour
{

    public int maxHealth = 1;
    public int health = 1;
    public int scoreAwarded = 1;
    public GameObject shatterEffect;

    private void Awake()
    {
        tag = "Hazard";
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDie()
    {
        AwardScore();
        Instantiate(shatterEffect, transform.position, transform.rotation);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.ToLower() == "bullet")
        {
            health--;
            GetComponent<InterpolateColor>().SetScale(1f - ((float)health / (float)maxHealth));
            GetComponent<FlashColor>().Flash();
            if (health <= 0)
            {
                SendMessage("OnDie");
                Destroy(gameObject);
            }
        }
    }


    private void AwardScore()
    {
        EventManager.ShiftScore(scoreAwarded);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class FlashColor: MonoBehaviour
{
    public Color flashColor = Color.red;
    public int intervals = 1;
    public float duration = 0.15f;

    private int currentInterval = 0;
    private Color originalColor;
    private float startTime = 0f;
    private float B;
    private float threshold = 0f;


    private void Awake()
    {
        this.enabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Flash()
    {
        B = (2 * Mathf.PI) / duration;
        originalColor = GetComponent<SpriteRenderer>().color;
        startTime = Time.time;
        this.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time < startTime + (duration * intervals))
        {
            if (GetX(Time.time) > threshold)
            {
                GetComponent<SpriteRenderer>().color = flashColor;
            }
            else
            {
                GetComponent<SpriteRenderer>().color = originalColor;
            }
        }
        else
        {
            GetComponent<SpriteRenderer>().color = originalColor;
            this.enabled = false;
        }
    }

    float GetX(float time) {
        return Mathf.Sin(B * (time - startTime));
    }
}

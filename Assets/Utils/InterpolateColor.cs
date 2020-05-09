using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class InterpolateColor : MonoBehaviour
{
    public Color initialColor;
    public Color finalColor;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = initialColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetScale(float scale)
    {
        GetComponent<SpriteRenderer>().color = Color.Lerp(initialColor, finalColor, scale);
    }
}

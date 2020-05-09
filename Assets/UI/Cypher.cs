using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cypher : MonoBehaviour
{
    public CharacterDefinitions characterDefinitions;
    public float spacing = 1.5f;
    public int width = 5;
    public int height = 5;
    public int centerX = 1;
    public int centerY = 2;
    public List<Vector2> pixels;
    public GameObject dot;
    private void Awake()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                pixels.Add(
                    new Vector2((x - centerX) * spacing, (y - centerY) * spacing * -1)
                );
            }
        }
        int i = 0;
        pixels.ForEach((p) => {
            GameObject newDot = Instantiate(dot, this.transform);
            newDot.transform.localPosition = p;
            newDot.name = "Dot #" + i++;
        });
    }
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    { 
    }

    public void ChangeCharacter(char character)
    {
        bool[,] def = characterDefinitions.getCharDefinition(character);

        for (int i = 0; i < width * height; i++)
        {
            transform.GetChild(i).gameObject.SetActive(def[i%width, i/width]);
        }
    }
}

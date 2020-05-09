using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phrase : MonoBehaviour
{
    public GameObject character;
    public int length;
    public string phrase;
    public float spacing = 1.5f;
    public int width = 5;
    public int height = 5;
    public int centerX = 1;
    public int centerY = 2;
    public bool alignLeft = true;
    private List<Cypher> cyphers;

    private void Awake()
    {
        cyphers = new List<Cypher>();
        for (int x = 0; x < length; x++)
        {
            float deltaX = width * spacing * x * transform.localScale.x;
            deltaX = alignLeft ? deltaX : deltaX * -1;
            Vector3 position = new Vector3(deltaX, 0, 0);
            Cypher cypher = Instantiate(
                character,
                transform.position + position,
                Quaternion.identity,
                transform
            ).GetComponent<Cypher>();
            cyphers.Add(cypher);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        UpdatePhrase(phrase);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdatePhrase(string newPhrase)
    {
        if (newPhrase == phrase)
            return;
        phrase = newPhrase;
        int x = 0;
        cyphers.ForEach((cypher) =>
        {
            int index = alignLeft ? x : phrase.Length - x - 1;
            cypher.ChangeCharacter(x < phrase.Length ? phrase[index] : ' ');
            x++;
        });
    }
}

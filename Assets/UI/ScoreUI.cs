using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Phrase))]
public class ScoreUI : MonoBehaviour
{
    public LevelStatus levelStatus;
    private Phrase phrase;

    private void Awake()
    {
        phrase = GetComponent<Phrase>();
        EventManager.OnShiftScore += levelStatus.ShiftScore;
    }
    // Start is called before the first frame update
    void Start()
    {    
        phrase.UpdatePhrase(levelStatus.score.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        phrase.UpdatePhrase(levelStatus.score.ToString());
    }
}

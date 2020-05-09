using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelStatus")]
public class LevelStatus : ScriptableObject
{
    public int score = 0;

    public void ShiftScore(int delta)
    {
        score += delta;
    }
}

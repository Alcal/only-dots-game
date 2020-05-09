using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterDefinitions")]
public class CharacterDefinitions : ScriptableObject
{
    bool[,] zero = {
        { true, true, true, false, false},
        { true, false, true, false, false},
        { true, false, true, false, false},
        { true, false, true, false, false},
        { true, true, true, false, false}
    };

    bool[,] one = {
        { false, true, true, false, false},
        { false, false, true, false, false},
        { false, false, true, false, false},
        { false, false, true, false, false},
        { false, false, true, false, false}
    };

    bool[,] two = {
        { true, true, true, false, false},
        { false, false, true, false, false},
        { true, true, true, false, false},
        { true, false, false, false, false},
        { true, true, true, false, false}
    };

    bool[,] three = {
        { true, true, true, false, false},
        { false, false, true, false, false},
        { false, true, true, false, false},
        { false, false, true, false, false},
        { true, true, true, false, false}
    };

    bool[,] four = {
        { true, false, true, false, false},
        { true, false, true, false, false},
        { true, true, true, false, false},
        { false, false, true, false, false},
        { false, false, true, false, false}
    };

    bool[,] five = {
        { true, true, true, false, false},
        { true, false, false, false, false},
        { true, true, true, false, false},
        { false, false, true, false, false},
        { true, true, true, false, false}
    };

    bool[,] six = {
        { true, true, false, false, false},
        { true, false, false, false, false},
        { true, true, true, false, false},
        { true, false, true, false, false},
        { true, true, true, false, false}
    };

    bool[,] seven = {
        { true, true, true, false, false},
        { false, false, true, false, false},
        { false, false, true, false, false},
        { false, true, false, false, false},
        { false, true, false, false, false}
    };

    bool[,] eight = {
        { true, true, true, false, false},
        { true, false, true, false, false},
        { true, true, true, false, false},
        { true, false, true, false, false},
        { true, true, true, false, false}
    };

    bool[,] nine = {
        { true, true, true, false, false},
        { true, false, true, false, false},
        { true, true, true, false, false},
        { false, false, true, false, false},
        { false, false, true, false, false}
    };

    bool[,] nill = {
        { false, false, false, false, false},
        { false, false, false, false, false},
        { false, true, false, false, false},
        { false, false, false, false, false },
        { false, false, false, false, false },
    };

    public bool[,] getCharDefinition(char character)
    {
        switch(character)
        {
            case '0':
                return zero;
            case '1':
                return one;
            case '2':
                return two;
            case '3':
                return three;
            case '4':
                return four;
            case '5':
                return five;
            case '6':
                return six;
            case '7':
                return seven;
            case '8':
                return eight;
            case '9':
                return nine;
            default:
                return nill;

        }
    }
}

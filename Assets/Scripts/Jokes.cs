using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "New Joke")]
public class Jokes : ScriptableObject
{
    public new string name;
    [TextArea]
    public string joke;

    public int laughLevel;
    public int colorEffect;

}

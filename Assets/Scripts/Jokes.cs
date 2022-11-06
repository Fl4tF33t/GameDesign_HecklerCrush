using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Joke")]
public class Jokes : ScriptableObject
{
    public new string name;
    public string description;

    public int laughLevel;
    public int colorEffect;

}

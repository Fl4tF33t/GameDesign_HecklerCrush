using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JokeDisplay : MonoBehaviour
{
    public List<Jokes> jokes;
    TextMeshProUGUI jokeText;

    // Start is called before the first frame update
    void Start()
    {
        jokeText = GetComponent<TextMeshProUGUI>();
        jokeText.text = jokes[1].description;
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JokeDisplay : MonoBehaviour
{
    public List<Jokes> jokes;
    TextMeshProUGUI jokeText;

    public bool isSelected = false;
    public int randomJokeIndex;

    // Start is called before the first frame update
    void Start()
    {
        jokeText = GetComponent<TextMeshProUGUI>();
        JokeSelection();
    }

    int JokeIndex()
    {
        return Random.Range(0, jokes.Count);
    }

    public void JokeSelection()
    {
        randomJokeIndex = JokeIndex();
        if (jokes.Count > 0)
        {
            jokeText.text = jokes[randomJokeIndex].joke;
        }
        
    }

}

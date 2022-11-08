using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudienceSelect : MonoBehaviour
{
    [SerializeField] JokeDisplay[] jokeDisplayInfo = new JokeDisplay[3];
    Button button;

    public int colorEffect;
    public int laughLevel;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
    }

    private void Update()
    {
        if (jokeDisplayInfo[0].isSelected == true || jokeDisplayInfo[1].isSelected == true || jokeDisplayInfo[2].isSelected == true)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;

        }
    }
    // Update is called once per frame

    
}

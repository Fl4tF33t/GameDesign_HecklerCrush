using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI laughOMeter;
    [SerializeField] JokeDisplay[] jokeDisplayInfo = new JokeDisplay[3];
    [SerializeField] Image[] buttonImage = new Image[3];
    [SerializeField] Button[] button = new Button[3];
    public Camera cam;
    public float decayRate = 2.5f;

    public int laughLevel = 0;

    private void Start()
    {
        laughLevel = 50;
        InvokeRepeating("LaughDecay", 2, decayRate);
    }

    private void LaughDecay()
    {
        laughLevel--;
    }


    void Update()
    {
        laughOMeter.text = "Laugh-O-Meter Level is: " + laughLevel;
    }

    public void Option1()
    {
        ColorChange(0);
        jokeDisplayInfo[0].isSelected = !jokeDisplayInfo[0].isSelected;
        button[1].interactable = !button[1].interactable;
        button[2].interactable = !button[2].interactable;
    }

    public void Option2()
    {
        ColorChange(1);
        jokeDisplayInfo[1].isSelected = !jokeDisplayInfo[1].isSelected;
        button[0].interactable = !button[0].interactable;
        button[2].interactable = !button[2].interactable;
    }
    public void Option3()
    {
        ColorChange(2);
        jokeDisplayInfo[2].isSelected = !jokeDisplayInfo[2].isSelected;
        button[0].interactable = !button[0].interactable;
        button[1].interactable = !button[1].interactable;
    }

    public void AudienceChoose()
    {
        if (jokeDisplayInfo[0].isSelected == true)
        {
            UIChanges(0);
        }
        else if (jokeDisplayInfo[1].isSelected == true)
        {
            UIChanges(1);
        }
        else if (jokeDisplayInfo[2].isSelected == true)
        {
            UIChanges(2);
        }
    }

    void UIChanges(int list)
    {
        jokeDisplayInfo[list].jokes.RemoveAt(jokeDisplayInfo[list].randomJokeIndex);
        jokeDisplayInfo[list].JokeSelection();
        button[0].interactable = true;
        button[1].interactable = true;
        button[2].interactable = true;
        buttonImage[list].color = Color.white;
        jokeDisplayInfo[list].isSelected = !jokeDisplayInfo[list].isSelected;
    }

    void ColorChange(int list)
    {
        if (buttonImage[list].color == Color.white)
        {
            buttonImage[list].color = Color.green;
        }
        else if (buttonImage[list].color == Color.green)
        {
            buttonImage[list].color = Color.white;
        }
    }

}

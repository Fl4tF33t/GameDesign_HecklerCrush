using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI laughOMeter;
    [SerializeField] TextMeshProUGUI boomMeter;
    [SerializeField] JokeDisplay[] jokeDisplayInfo = new JokeDisplay[3];
    [SerializeField] Image[] buttonImage = new Image[3];
    [SerializeField] Button[] button = new Button[3];
    [SerializeField] GameObject nextLevel;
    [SerializeField] GameObject endBoom;
    [SerializeField] GameManager gmInfo;
    public Camera cam;
    public float decayRate = 2.5f;

    bool boomButtonPressed = false;

    public int laughLevel = 0;
    public int boomLevel = 0;

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
        if (boomButtonPressed == false)
        {
            laughOMeter.text = "Laugh-O-Meter Level is: " + laughLevel;
        }else if (boomButtonPressed == true)
        {
            laughOMeter.text = "You're Hilarious, you win!";
        }
        if (laughLevel == 0)
        {
            CancelInvoke("LaughDecay");
            laughOMeter.text = "You Suck as a comedian";
        }
        boomMeter.text = "Boom level is: " + boomLevel;
        if(boomLevel >= 10)
        {
            endBoom.SetActive(true);
        }
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

    public void BoomButton()
    {
        boomButtonPressed = true;
        CancelInvoke("Laugh Decay");
        gmInfo.CancelInvoke("SpawnSystem");
    }

    public void BoomButtonInactive()
    {
        boomButtonPressed = false;
        endBoom.SetActive(false);
        nextLevel.SetActive(true);
    }

    public void StartNextLevel()
    {
        laughLevel = 50;
        decayRate = 1;
        InvokeRepeating("LaughDecay", 2, decayRate);
        gmInfo.InvokeRepeating("Spawn System", 1, 1);

        nextLevel.SetActive(false);
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

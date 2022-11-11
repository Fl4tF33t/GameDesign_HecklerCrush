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
    public int leaveLevel;

    Image image;
    [SerializeField] UIManager uiManagerInfo;
    
    // Start is called before the first frame update
    public void Start()
    {
        colorEffect = Random.Range(1, 4);
        laughLevel = Random.Range(1, 4);
        leaveLevel = 2;
        button = GetComponent<Button>();
        image = GetComponent<Image>();
        if(colorEffect == 1)
        {
            image.color = Color.red;
        }else if(colorEffect == 2)
        {
            image.color = Color.yellow;
        }
        else if (colorEffect == 3)
        {
            image.color = Color.green;
        }
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
        if(leaveLevel < 1)
        {
            this.gameObject.SetActive(false);
        }
    }
    
    public void MathCalcScore()
    {
        if (jokeDisplayInfo[0].isSelected == true)
        {
            IsMatching(0);
        }
        else if(jokeDisplayInfo[1].isSelected == true)
        {
            IsMatching(1);

        }
        else if(jokeDisplayInfo[2].isSelected == true)
        {
            IsMatching(2);

        }
    }

    void IsMatching(int list)
    {
        if (this.colorEffect == jokeDisplayInfo[list].jokes[jokeDisplayInfo[list].randomJokeIndex].colorEffect)
        {
            print("you offended the same color");
            uiManagerInfo.laughLevel += 1;
            uiManagerInfo.boomLevel += 1;
            leaveLevel--;
        }
        if (this.laughLevel == jokeDisplayInfo[list].jokes[jokeDisplayInfo[list].randomJokeIndex].laughLevel)
        {
            print("you offended the same shape");
            uiManagerInfo.laughLevel += 1;
            uiManagerInfo.boomLevel += 1;
            leaveLevel--;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI laughOMeter;


    int laughLevel = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        laughOMeter.text = "Laugh-O-Meter Level is: " + laughLevel;
    }

    public void Option1()
    {
        laughLevel += 1;
    }

    public void Option2()
    {
        laughLevel += 1;
    }
    public void Option3()
    {
        laughLevel += 1;
    }
}

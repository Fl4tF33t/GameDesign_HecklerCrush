using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject[] audienceList;


    // Start is called before the first frame update
    void Start()
    {
        audienceList = GameObject.FindGameObjectsWithTag("Audience");
        for (int i = 0; i < audienceList.Length; i++)
        {
            audienceList[i].SetActive(false);
        }
        InvokeRepeating("SpawnSystem", 1, 1);
    }

   void SpawnSystem()
   {
        int randomAudience = Random.Range(0, audienceList.Length);
        if (audienceList[randomAudience].activeSelf == false)
        {
            AudienceSelect spawn = audienceList[randomAudience].GetComponent<AudienceSelect>();
            spawn.Start();
            audienceList[randomAudience].SetActive(true);
        }
        
   }

    public void LevelOver()
    {
        //int index = -1;
        for (int i = 0; i < audienceList.Length; i++)
        {
            if (audienceList[i].activeSelf == true)
            {
                /*index++;
                numbers[index] = i;
                Debug.Log(numbers[0]);*/
                AudienceSelect spawn = audienceList[i].GetComponent<AudienceSelect>();
                //spawn.Start();
                audienceList[i].SetActive(false);
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

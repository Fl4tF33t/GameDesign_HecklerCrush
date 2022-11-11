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
        InvokeRepeating("SpawnSystem", 1, 2);
    }

   void SpawnSystem()
   {
        List<int> numbers = new List<int>();
        for (int i = 0; i < audienceList.Length; i++)
        {
            if (audienceList[i].activeSelf == false)
            {
                numbers.Add(i);
                Debug.Log(numbers);
                AudienceSelect spawn = audienceList[i].GetComponent<AudienceSelect>();
                spawn.Start();
                audienceList[i].SetActive(true);
            }
        }
   }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}

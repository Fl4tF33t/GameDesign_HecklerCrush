using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScalableAudience : MonoBehaviour
{
    GameObject[] audience;

    // Start is called before the first frame update
    void Start()
    {
        audience = GameObject.FindGameObjectsWithTag("Audience");
        for (int x = 0; x < 5; x++)
        {
            for (int y = 0; y < 5; y++)
            {
                Debug.Log(audience[(x * 5) + y].transform.position.x);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

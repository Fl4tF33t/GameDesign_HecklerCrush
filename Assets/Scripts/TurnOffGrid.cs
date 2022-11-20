using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnOffGrid : MonoBehaviour
{
    GridLayoutGroup glGroup;

    // Start is called before the first frame update
    void Start()
    {
        glGroup = GetComponent<GridLayoutGroup>();
        StartCoroutine("TurnOFF");
    }

    IEnumerator TurnOFF()
    {
        yield return new WaitForSeconds(1f);
        glGroup.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

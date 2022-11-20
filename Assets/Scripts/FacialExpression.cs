using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FacialExpression : MonoBehaviour
{
    public Sprite[] facialExpression;
    AudienceSelect audienceSelectInfo;
    Image image;
    
    // Start is called before the first frame update
    void Start()
    {
        audienceSelectInfo = GetComponentInParent<AudienceSelect>();
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(audienceSelectInfo.leaveLevel == 3)
        {
            this.image.sprite = facialExpression[0];
        }else if (audienceSelectInfo.leaveLevel == 2)
        {
            this.image.sprite = facialExpression[1];
        }else if (audienceSelectInfo.leaveLevel == 1)
        {
            this.image.sprite = facialExpression[2];
        }
    }
}

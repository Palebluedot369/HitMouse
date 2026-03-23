using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class finalpoint : MonoBehaviour
{
    public TextMeshProUGUI finalPoint;

    public void FinalPoint()
    {
        finalPoint.text = "你的得分为" + Point.destroycount ;
    }
    public void Start()
    {
        FinalPoint();        
    }

}

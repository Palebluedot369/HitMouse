using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bestpoint : MonoBehaviour
{
    public TextMeshProUGUI bestPoint;
    public int bestcount;
    private const string best_key = "bestcount";

    void best()
    {
        if(bestcount < Point.destroycount)
        {
            bestcount = Point.destroycount;
            PlayerPrefs.SetInt(best_key, bestcount);
        }
        bestPoint.text = "你的最佳记录：" + bestcount + "分";
    }
    public void Start()
    {
        bestcount = PlayerPrefs.GetInt(best_key,0);
        best();
    }

}

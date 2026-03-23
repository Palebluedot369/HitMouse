using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Point : MonoBehaviour
{
    public TextMeshProUGUI point;
    public static int destroycount = 0;

    // Start is called before the first frame update
    void Start()
    {
        point.text = "得分：" + destroycount;
    }

    public void pointcount()
    {
        destroycount++;
        UpdateUI();
    }

    // Update is called once per frame
    private void UpdateUI()
    {
        if (point != null)
        {
            point.text = "得分：" + destroycount;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class timetest : MonoBehaviour
{
    public TextMeshProUGUI time;    
    public float timecount = 30.0f; //游戏时长30s
    public bool iscounting = false;

    // Start is called before the first frame update
    void Start()
    {
        time.text = "倒计时：" + timecount;
        iscounting = true;
    }
    


    // Update is called once per frame
    void Update()
    {
        if (iscounting)
        {
            if (timecount > 0)
            {
                timecount -= Time.deltaTime;
                UpdateUI();
            }
            else
            {
                timecount = 0;
                iscounting = false;
                LoadSence("Endgame");
            }
        }
    }


    void UpdateUI()
    {
        int seconds = Mathf.FloorToInt(timecount % 60);
        time.text = "倒计时：" + seconds.ToString();
    }

    public void LoadSence(string Endgame)
    {
        SceneManager.LoadScene(Endgame);
    }
}

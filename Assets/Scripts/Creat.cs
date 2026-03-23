using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Creat : MonoBehaviour
{

    public GameObject Mouse;
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        //游戏开始后创建一个地鼠，随后在1-2秒内随机创建一个地鼠
        InvokeRepeating("creat", 0, Random.Range(1f, 2f));
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("mouse").Length < 2)
        {
            Invoke("creat", Random.Range(0, 1));
        }
    }
    void creat()
    {
        int[] xpos = { -2, 0, 2 };
        int[] ypos = { -1, 0, 1 };
        int randomX = xpos[Random.Range(0, xpos.Length)];
        int randomY = ypos[Random.Range(0, ypos.Length)];
        pos = new Vector3(randomX, randomY, 10);
        //获取layer为mouse的碰撞体
        LayerMask tag = LayerMask.GetMask("mouse");
        //进行碰撞体检测
        Collider[] hit = Physics.OverlapSphere(pos, 0.1f);
        //碰撞距离为0（即没有物体时）创建地鼠
        if (hit.Length == 0)
        {
            Instantiate(Mouse, pos, Quaternion.Euler(0, 90, 0));
        }

    }
}

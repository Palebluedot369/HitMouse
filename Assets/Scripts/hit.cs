using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    public GameObject hitedMouse;
    public Point point;
    // Start is called before the first frame update
    void Start()
    {
        //将计分器加载到游戏对象内
        point = FindObjectOfType<Point>();
       //出现后1~3s内消失
       Destroy(gameObject,Random.Range(1,3));
    }

    private void OnMouseDown()
    {
        //调用计分方法
        point.pointcount();
        //生成被击打特效,摧毁原有游戏对象
        Instantiate(hitedMouse,transform.position, Quaternion.Euler(0,90,0));
        Destroy(gameObject);
    }
}

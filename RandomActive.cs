using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomActive : MonoBehaviour
{
    public int 启用概率;//预制体的启用概率 
    public void 启用判断() {
        int 随机生成数 = Random.Range(0, 101);   //随机生成一个整数 范围在0到101之间包括0不包括101
        if (随机生成数 <= 启用概率){             //比较两个数的大小，若低于启用概率则启用该GameObject
            this.gameObject.SetActive(true);
        } else {
            this.gameObject.SetActive(false);    //高于启用概率则禁用该GameObject
        }
    }
}

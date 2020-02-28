using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomActiveGroup : MonoBehaviour
{
    public GameObject[] 预制组;             //这个预制组包涵了一组需要的生成的所有备选预制
    public void 启用预制() {
        int 预制组长度 = 预制组.Length;     //数一下这个预制组的长度
        禁用全员(预制组长度);                         //先将所有的成员禁用,防止该方法被调用多次，导致启用多个预制
        int 随机数 = Random.Range(0, 预制组长度);   //在此上限为预制组长度-1，因为数组的索引是0，如果+1的话就会超出长度从而报错
        预制组[随机数].gameObject.SetActive(true);  //设置启用一个预制  
    }
    void 禁用全员(int 预制组长度) {   
        for (int i = 0; i < 预制组长度;i++) {   //遍历数组，并将所有成员禁用
            预制组[i].SetActive(false);
        }
    }
}

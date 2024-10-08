using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int type = 1;
    public string name = "1234";
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Dead", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Dead()
    {
        Debug.Log("怪物死亡");

        //触发事件
        EventCenter.GetInstance().EventTrigger("MonsterDead",this);
    }
}

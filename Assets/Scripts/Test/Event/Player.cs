using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Start()
    {
        EventCenter.GetInstance().AddEventListener<Monster>("MonsterDead", MonsterDeadDo);
    }

    public void MonsterDeadDo(object info )
    {
        Debug.Log("玩家得奖励" + (info as Monster).name);
    }

    private void OnDestroy()
    {
        EventCenter.GetInstance().RemoveEventListener<Monster>("MonsterDead", MonsterDeadDo);
    }
}

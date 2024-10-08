using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Other : MonoBehaviour
{
    private void Start()
    {
        EventCenter.GetInstance().AddEventListener<Monster>("MonsterDead", OtherWaitMonsertDeadDo);
    }

    public void OtherWaitMonsertDeadDo(object info)
    {
        Debug.Log("其他 各个对象要做的事");
    }

    private void OnDestroy()
    {
        EventCenter.GetInstance().RemoveEventListener<Monster>("MonsterDead", OtherWaitMonsertDeadDo);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    private void Start()
    {
        EventCenter.GetInstance().AddEventListener<Monster>("MonsterDead", TaskWaitMonsertDeadDo);

    }

    public void TaskWaitMonsertDeadDo(object info)
    {
        Debug.Log("任务记录");
    }

    private void OnDestroy()
    {
        EventCenter.GetInstance().RemoveEventListener<Monster>("MonsterDead", TaskWaitMonsertDeadDo);
    }
}

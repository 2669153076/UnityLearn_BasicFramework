using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayDisable : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        Invoke("Push", 1);
    }

    public void Push()
    {
        PoolMgr.GetInstance().Push(gameObject.name, gameObject);
    }
}

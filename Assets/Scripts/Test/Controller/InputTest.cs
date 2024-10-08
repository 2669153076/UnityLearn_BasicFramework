using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PoolMgr.GetInstance().Get("Test/Cube");
        }
        if (Input.GetMouseButtonDown(1))
        {
            PoolMgr.GetInstance().Get("Test/Sphere");
            
        }
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            SceneMgr.GetInstance().LoadSceneAsync("1", () => { Debug.Log("加载场景成功"); });
            EventCenter.GetInstance().AddEventListener<float>("UpdateProgress", (value) =>
            {
                Debug.Log("进度"+value);
            });
        }
    }
}

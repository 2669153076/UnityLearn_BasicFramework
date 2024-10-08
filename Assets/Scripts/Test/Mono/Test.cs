using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_a
{
    public void Update()
    {
        Debug.Log("hui");
    }

    IEnumerator TestCortine()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("自定义");
    }

    public void Te()
    {
        MonoMgr.GetInstance().StartCoroutine(TestCortine());
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Test_a test_A = new Test_a();
        MonoMgr.GetInstance().AddUpdateListener(test_A.Update);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

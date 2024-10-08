using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginPanel : BasePanel
{
    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        GetControl<Text>("Title").text = "开始界面";
        //GetControl<Button>("Quit").onClick.AddListener(()=> { Debug.Log("退出"); });
    }

    public override void ShowSelf()
    {
        base.ShowSelf();    

    }

    public override void OnClick(string btnName)
    {
        switch (btnName)
        {
            case "Start":
                Debug.Log("开始");
                break;
            case "Quit":
                Debug.Log("退出");
                break;
        }
    }
}

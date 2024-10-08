using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTest : MonoBehaviour
{
    float v;
    GUIStyle s;
    GUIStyle s1;
    private void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 100, 100), "播放音乐"))
        {
            v = 0;
            MusicMgr.GetInstance().ChangeBkVolume(v);
            MusicMgr.GetInstance().PlayBkMusic("Black");
        }

        if (GUI.Button(new Rect(0, 100, 100, 100), "暂停音乐"))
            MusicMgr.GetInstance().PauseMusic();

        if (GUI.Button(new Rect(0, 200, 100, 100), "停止音乐"))
            MusicMgr.GetInstance().StopBkMusic();

        MusicMgr.GetInstance().ChangeBkVolume(v);
        v += Time.deltaTime*0.1f;

        if (GUI.Button(new Rect(0, 300, 100, 100), "播放音效"))
        {
            MusicMgr.GetInstance().PlaySound("Black",false);
        }

    }
}

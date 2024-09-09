using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    [SerializeField] AudioSource bgm;
    JudgeGameStart judgeGameStart;
    void Start()
    {
        judgeGameStart = GameObject.FindWithTag("GameStartManager").GetComponent<JudgeGameStart>();
    }

    void Update()
    {
        if(judgeGameStart.IsStarted_Moment)//ゲームが開始された瞬間にBGMを流す
        {
            bgm.Play();
        }
    }
}

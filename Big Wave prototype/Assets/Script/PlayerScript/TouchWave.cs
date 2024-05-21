using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchWave : MonoBehaviour
{
    [HideInInspector] public bool touchWaveNow=false;//今波に触っているか
    private float sinceLastTouchWaveTime = 0.1f;//最後に波に触ってからの時間
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        JudgeTouchWave();////波に触れているか判定
    }

    void OnTriggerEnter(Collider t)
    {
        if (t.gameObject.CompareTag("InsideWave") || t.gameObject.CompareTag("OutsideWave"))//波に触れているならWaveの情報(isTouched)を取得
        {
            sinceLastTouchWaveTime = 0f;//最後に波に触ってからの時間
        }
    }

    void JudgeTouchWave()//波に触れているか判定
    {
        sinceLastTouchWaveTime += Time.deltaTime;

        if (sinceLastTouchWaveTime < 0.1f)
        {
            touchWaveNow = true;
        }
        else
        {
            touchWaveNow = false;
        }
    }
}

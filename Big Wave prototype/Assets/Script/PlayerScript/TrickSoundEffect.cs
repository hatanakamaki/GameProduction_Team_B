using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class TrickSoundEffect : MonoBehaviour
{
    [Header("クリティカル時の効果音")]
    [SerializeField] AudioClip criticalSE;//クリティカル時の効果音
    [Header("通常状態の効果音")]
    [SerializeField] AudioClip normalSE;//通常状態の効果音
    [Header("最大ピッチ")]
    [SerializeField] float pitchMax;
    [Header("上昇ピッチ量")]
    [SerializeField] float pitchUp;
    [SerializeField] UnityEvent trickEvent_F;
    [SerializeField] UnityEvent trickEvent_N;
    [SerializeField] UnityEvent trickEvent_Fever;
    [Header("必要なコンポーネント")]
    [SerializeField] AudioSource audioSource;
    [SerializeField] Critical critical;
    [SerializeField]FeverMode feverMode;
    private float startPitch;
    private void Start()
    {
       startPitch= audioSource.pitch;
    }
    public void PlayTrickSE()//クリティカル状況によって鳴らす音を変える
    {
        AudioClip se=critical.CriticalNow ? criticalSE: normalSE;
        if (critical.CriticalNow&&audioSource.pitch<pitchMax)
        {
            audioSource.pitch += pitchUp;
        }
        else if(!critical.CriticalNow)
        {
          audioSource.pitch =startPitch ;
        }
        audioSource.PlayOneShot(se);
    }
    public void PlayTrickEffect()//トリックの成否や状態に合わせて表示させるエフェクトを変える
    {
        if(critical.CriticalNow)
        {
            if (feverMode.FeverNow)
            {
                trickEvent_Fever.Invoke();
            }
            else
            {
                trickEvent_N.Invoke();
            }

        }
        else
        {
            trickEvent_F.Invoke();
        }
    }
}

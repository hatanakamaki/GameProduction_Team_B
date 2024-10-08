using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    [Header("ゲーム中断時に呼ぶイベント")]
    [SerializeField] UnityEvent quitEvents;

    public void Quit()//ゲーム中断時の処理
    {
        quitEvents.Invoke();
        SceneManager.LoadScene("MenuScene");
    }
}

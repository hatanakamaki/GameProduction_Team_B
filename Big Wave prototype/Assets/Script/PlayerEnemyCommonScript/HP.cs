using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    [Header("最大体力")]
    [SerializeField] float hpMax = 500;//最大体力
    private float hp = 500;//現在の体力
    

    public float Hp
    {
        get { return hp; }
        set 
        {
            hp = value;
            hp = Mathf.Clamp(hp, 0f, hpMax);//体力が限界突破しないように
        }
    }

    public float HpMax
    {
        get { return hpMax; }
        set { hpMax = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        //Hpの初期化
        hp = hpMax;   
    }

    // Update is called once per frame
    void Update()
    {
    }
}

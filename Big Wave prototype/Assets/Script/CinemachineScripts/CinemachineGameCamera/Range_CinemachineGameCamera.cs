using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//作成者:杉山
//ゲーム中のカメラの切り替え条件
public partial class CinemachineGameCamera
{
    [System.Serializable]
    class Range//範囲
    {
        [SerializeField] float deadZoneHeight;
        bool outBeforeFrame = false;//前のフレームでターゲットが範囲外に出ていたか
        bool goOut = false;//範囲外に出た瞬間
        bool goIn = false;//範囲内に入った瞬間

        public bool GoOut { get { return goOut; } }//範囲外に出た瞬間
        public bool GoIn { get { return goIn; } }//範囲内に入った瞬間

        Range()//コンストラクタ
        {

        }

        public void UpdateOutOfRange(Vector3 localPos_target)
        {
            bool outNow = localPos_target.y >= deadZoneHeight;//範囲外に出ているかの条件

            goOut = outNow && !outBeforeFrame;//範囲外に出た瞬間の判定の更新
            goIn = !outNow && outBeforeFrame;//範囲内に入った瞬間の判定の更新

            outBeforeFrame = outNow;//前フレームのターゲットが範囲外に出ていたかの判定の更新
        }
    }
}

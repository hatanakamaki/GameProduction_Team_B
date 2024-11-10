using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�쐬��:���R
//�Q�[���V�[���ł̃`���[�W�^�C���X�R�A�̌v���E����
public class ScoreGameScene_ChargeTime : MonoBehaviour
{
    [Header("�c�莞��(1�b)���Ƃ̃X�R�A��")]
    [SerializeField] float m_scorePerSecond;//�c�莞��(1�b)���Ƃ̃X�R�A��
    [Header("�X�R�A���f�Ɏg���R���|�[�l���g")]
    [SerializeField] Score_ChargeTime_ score_ChargeTime;//�X�R�A���f
    [Header("�`���[�W���Ԃ��v������R���|�[�l���g")]
    [SerializeField] CountChargeTime countChargeTime;

    public float Score { get { return countChargeTime.ChargeTime * m_scorePerSecond; } }//�X�R�A�̌v�Z��

    public void Reflect()//�X�R�A���f
    {
        score_ChargeTime.Rewrite(Score, countChargeTime.ChargeTime, m_scorePerSecond);
    }
}
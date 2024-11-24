using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�쐬��:���R
//�W�����v�͂�Ԃ�
public class JumpPower : MonoBehaviour
{
    [Header("�W�����v�p���[�̎����ƃ{�^��������������̏����l")]
    [SerializeField] RepetitiveValue_Sin _repetitiveValue;
    [Header("�W�����v�֌W�̃R���g���[������")]
    [SerializeField] ControllerOfJump _controllerOfJump;//�W�����v�֌W�̃R���g���[������
    [Header("�ő�W�����v��")]
    [SerializeField] float _powerMax;
    [Header("�ŏ��W�����v��")]
    [SerializeField] float _powerMin;
    [Header("�K�v�ȃR���|�[�l���g")]
    [SerializeField] JudgeJumpable _judgeJumpable;

    public float Power//�W�����v��
    {
        get
        {
            float gap=_powerMax - _powerMin;//�ő�W�����v�͂ƍŏ��W�����v�͂̍�
            return _powerMin+gap*_repetitiveValue.Value;
        }
    }

    public float Ratio { get { return _repetitiveValue.Value; } }//�W�����v�͂̊���(�ŏ��Ȃ�0�A�ő�Ȃ�1)

    public bool ChargeNow { get { return _judgeJumpable.Jumpable && _controllerOfJump.Pushing; } }//�W�����v�̓`���[�W�����A�W�����v�ł��鎞���R���g���[���̃W�����v�{�^�������������Ă��鎞

    public void ResetJumpPower()//�W�����v�͂̃��Z�b�g�A�W�����v(����)����������̓W�����v���o���Ȃ��Ȃ�������ɂ���
    {
        _repetitiveValue.ResetCycle();
    }

    void Start()
    {
        _repetitiveValue.ResetCycle();
        _judgeJumpable.ToNotJumpable += ResetJumpPower;
    }

    void Update()
    {
        Charge();
    }

    void Charge()//�W�����v�͂̃`���[�W
    {
        if (ChargeNow)
        {
            _repetitiveValue.UpdateValue();
        }    
    }
}
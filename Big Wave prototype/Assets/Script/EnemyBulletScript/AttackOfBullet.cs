using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackOfBullet : MonoBehaviour
{
    //������������
    [SerializeField] float damage;//�_���[�W��
    [SerializeField] bool ifHitDestroy=true;//�v���C���[�ɓ����������ɒe��������
    Player player;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider t)
    {
        if(t.gameObject.CompareTag("Player"))
        {
            player= t.GetComponent<Player>();

            if(player.Barrier==false)//���G��Ԃ���Ȃ����v���C���[�Ƀ_���[�W��^����
            {
                player.Hp -= damage;
            }

            if(ifHitDestroy)//true�������������e��������
            {
                Destroy(gameObject);
            }
        }
    }
}
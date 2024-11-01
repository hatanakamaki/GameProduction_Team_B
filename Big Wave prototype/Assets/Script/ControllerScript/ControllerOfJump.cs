using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//作成者:杉山
//ジャンプの操作
public class ControllerOfJump : MonoBehaviour
{
    Jump jump;
    void Start()
    {
        jump = GameObject.FindWithTag("Player").GetComponent<Jump>();
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (!context.performed) return;

        jump.JumpTrigger();
    }
}

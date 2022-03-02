using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        var gamePad = Gamepad.current;
        if(gamePad == null)
        {
            return;
        }
        else
        {
            Debug.Log("Game Pad�� �������ֽ��ϴ�.");
        }
        Vector2 move = gamePad.leftStick.ReadValue();

        Debug.Log("move : " + move);
    }
}

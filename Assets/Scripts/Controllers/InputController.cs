using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace unity3dexperience.Controller
{

public class InputController : MonoBehaviour
{
    private bool _isActiveFlashlight = false;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            _isActiveFlashlight = !_isActiveFlashlight;
            if (_isActiveFlashlight)
            {
                // Вызов функции On() класса FlashlightController
            }
            else
            {
                // Вызов функции Off() класса FlashlightController
            }
        }
    }

}

}

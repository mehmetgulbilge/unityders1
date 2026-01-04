using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InvokeMethod : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Invoke("Yaziyaz", 2f);
        InvokeRepeating("Yaziyaz", 2f, .8f);
    }

    void Yaziyaz()
    {
        Debug.Log("Yaziyaz method called");
    }

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && IsInvoking("Yaziyaz"))
        {
            CancelInvoke("Yaziyaz");
        }
    }
}

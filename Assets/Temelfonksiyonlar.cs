using System;
using UnityEngine;

public class Temelfonksiyonlar : MonoBehaviour
{
    // İlk önce bu çalışır ve sadece bir kez çalışır
    private void Awake()
    {
        Debug.Log("Awake çalıştı");
    }

    // MonoBehaviour etkinleştirildiğinde çalışır
    private void OnEnable()
    {
        Debug.Log("OnEnable çalıştı");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start çalıştı");
    }

    // FixedUpdate her sabit bir zaman aralığında çalışır
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate çalıştı: " + Time.fixedDeltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update çalıştı");
    }
    
    // LateUpdate her frame sonunda çalışır
    private void LateUpdate()
    {
        Debug.Log("LateUpdate çalıştı");
    }

    // MonoBehaviour devre dışı bırakıldığında çalışır
    private void OnDisable()
    {
        Debug.Log("OnDisable çalıştı");
    }
}

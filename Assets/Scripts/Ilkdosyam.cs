using System.Collections.Generic;
using UnityEngine;

public class Ilkdosyam : MonoBehaviour
{
    public string Ad;
    public int Yas;
    public float Maas;
    public bool ArabaVarMi;

    public string[] cocuklar;
    public List<string> babalar;
    private string Memleket;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        Memleket = "Sivas";
        Debug.Log("Merhaba, benim adım " + Ad);
        Debug.Log("Yaşım " + Yas + " ve maaşım " + Maas);
        if (Yas == 18) ArabaVarMi = true;
        else ArabaVarMi = false;

        foreach (var cocuk in cocuklar) Debug.Log(cocuk);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
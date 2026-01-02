using System.Collections.Generic;
using UnityEngine;

public class listtunceli : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        List<int> sayilar = new List<int>();
        sayilar.Add(50);
        sayilar.Add(40);
        sayilar.Add(18);

        List<string> isimler = new List<string>();

        isimler.Add("Mehmet");
        isimler.Add("Ahmet");
        isimler.Add("Murat");

        // Debug.Log(isimler[0]);
        // Debug.Log(isimler[1]);
        // Debug.Log(isimler[2]);
        isimler.Insert(1, "Ebru");
        foreach (var isim in isimler)
        {
            Debug.Log(isim);
        }

        if (isimler.Contains("Murat"))
        {
            Debug.Log("Murat var");
        }
        else
        {
            Debug.Log("Murat yok");
        }

        isimler.Clear();
        Debug.Log(isimler.Count);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

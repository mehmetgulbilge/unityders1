using UnityEngine;

public class diziler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // int[] sayilar = new int[5];
        // string[] yazilar = new string[2];

        // int[] sayilarim = new int[] { 1, 2, 3, 4, 5 };

        // int[] sayilarim = { 1, 2, 3, 4, 5 };
        string[][] arabalar = new string[3][];
        arabalar[0] = new string[] { "BMW", "Mercedes", "Audi" };
        arabalar[1] = new string[] { "2024", "2025", "2023" };
        arabalar[2] = new string[] { "Kırmızı", "Mavi", "Siyah" };
        Debug.Log(arabalar[0][0]);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

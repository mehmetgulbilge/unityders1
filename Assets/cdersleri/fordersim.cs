using UnityEngine;

public class fordersim : MonoBehaviour
{
    readonly int disaridansayi = 5;

    void Start()
    {
        for (var sayi = 0; sayi < disaridansayi; sayi++)
        {
            if (sayi == 2) continue;
            if (sayi == 2) break;
            Debug.Log("Sayi: " + sayi);
        }
    }
}

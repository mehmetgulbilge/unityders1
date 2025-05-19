using UnityEngine;

public class whiletunceli : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sayi = 0;
        do
        {
            Debug.Log(sayi);
            sayi++;
        } while (sayi <= 1);
        // while (sayi < 1)
        // {
        //     Debug.Log(sayi);
        //     sayi++;
        // }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

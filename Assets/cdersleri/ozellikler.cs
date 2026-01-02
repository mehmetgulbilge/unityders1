using UnityEngine;

public class ozellikler : MonoBehaviour
{
    public int sayi;

    public int Sayi
    {
        get { return sayi; }
        set { sayi = value; }
    }

    public int ikinciSayi;

    public ozellikler(int ikinciSayi)
    {
        IkinciSayi = ikinciSayi;
    }

    public int IkinciSayi { get; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sayi = 5;
        ikinciSayi = 10;

        Debug.Log("Sayi: " + sayi);
        Debug.Log("Ikinci Sayi: " + IkinciSayi);

    }

    // Update is called once per frame
    void Update()
    {

    }
}

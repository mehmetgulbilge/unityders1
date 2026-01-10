using UnityEngine;

public class MethodIslemleri : MonoBehaviour
{
    private readonly string _ad = "Mehmet";

    private readonly int _sayi = 50;

    private string _ad2 = "Ebru";

    private string _veri;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        string kopyalanan = (string)_ad.Clone();
        string kopyalanan2 = _sayi.ToString();

        print(kopyalanan);
        print(kopyalanan2);
        print(_sayi.GetType());

        if (_ad.Equals("Mehmet"))
            print("Ad doğru");
        else
            print("Ad yanlış");
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
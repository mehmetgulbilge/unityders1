using UnityEngine;

public class degiskenler: MonoBehaviour
{

    public string metnim = "Mehmet";
    public int yas = 30;
    public float pi = 3.14f;
    public double piDouble = 3.14159265358979323846;
    public bool dogruMu = true;
    void Start()
    {
        metnim = "Ahmet";
        Debug.Log("Metin: " + metnim);
        Debug.Log("Yaş: " + yas);
        Debug.Log("Pi: " + pi);
        Debug.Log("Pi Double: " + piDouble);
        Debug.Log("Doğru mu: " + dogruMu);
    }
}

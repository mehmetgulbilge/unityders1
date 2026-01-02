using UnityEngine;
using namespacem;

public class classvefonkdersi : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // namespacem.Okul
        Okul okul = new Okul();
        okul.getOkulAdi();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

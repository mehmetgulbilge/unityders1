using namespacem;
using UnityEngine;

public class classvefonkdersi : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        // namespacem.Okul
        var okul = new Okul();
        okul.getOkulAdi();
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
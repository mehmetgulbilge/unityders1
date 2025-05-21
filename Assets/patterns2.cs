using UnityEngine;

public class patterns2 : MonoBehaviour
{
    string name = "villa";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float AidatHesapla(patterns2 sinif, int aidatCarpan) => sinif switch
        {
            { name: "villa" } => aidatCarpan * 1.54f,
            { name: "daire" } => aidatCarpan * 1.25f,
            { name: "müstakil" } => aidatCarpan * 1.75f,
        };

        Debug.Log(AidatHesapla(this, 100));
    }

    // Update is called once per frame
    void Update()
    {

    }
}

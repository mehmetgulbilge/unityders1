using UnityEngine;

public class patterns2 : MonoBehaviour
{
    string name = "apart";
    string daire = "1+1";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float AidatHesapla(patterns2 sinif, float aidatCarpan) => sinif switch
        {
            { name: "villa", daire: "1+1" } => aidatCarpan * 2.5f,
            { name: "daire" } => aidatCarpan * 1.25f,
            { name: "müstakil" } => aidatCarpan * 1.75f,
            _ => 0
        };

        Debug.Log(AidatHesapla(this, 100));
    }

    // Update is called once per frame
    void Update()
    {

    }
}

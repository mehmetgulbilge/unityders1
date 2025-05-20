using UnityEngine;

public class patterns : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string bir = "taş";
        string iki = "kağıt";

        string taskagitmakas(string a, string b) => (a, b) switch
        {
            ("taş", "kağıt") => "Kağıt kazandı",
            ("kağıt", "makas") => "Makas Kazandı",
            // ("taş")

        };
    }

    // Update is called once per frame
    void Update()
    {

    }
}

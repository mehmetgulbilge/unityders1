using UnityEngine;

public class patterns : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string bir = "taş";
        string iki = "kağıt";

        string Taskagitmakas(string a, string b) => (a, b) switch
        {
            ("taş", "kağıt") => "Kağıt kazandı",
            ("kağıt", "makas") => "Makas Kazandı",
            ("makas", "taş") => "Taş Kazandı",
            ("taş", "taş") => "Berabere",
            ("kağıt", "kağıt") => "Berabere",
            ("makas", "makas") => "Berabere",
            ("taş", "makas") => "Taş Kazandı",
            ("kağıt", "taş") => "Kağıt Kazandı",
            ("makas", "kağıt") => "Makas Kazandı",
            _ => "Hata"
        };

        Debug.Log(Taskagitmakas(bir, iki));
    }

    // Update is called once per frame
    void Update()
    {

    }
}

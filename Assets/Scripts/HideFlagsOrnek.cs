using UnityEngine;

[AddComponentMenu("Scripts/Beni Ekle")]
public class HideFlagsOrnnek : MonoBehaviour
{
    [Header("Karakter Bilgileri")] public string saglik;

    public string para;
    public string level;

    [Header("Düşman Bilgileri")] public string dusman_saglik;

    public string dusman_para;
    public string dusman_level;

    // [Multiline(3)] public string ad;
    //
    // [Range(1, 10)] public int sayi;
    //
    // [HideInInspector] public string soyad;
    //
    // [Tooltip("Aktif mi?")] public bool aktif = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        // gameObject.hideFlags = HideFlags.DontSave;
    }

    // Update is called once per frame
    private void Update()
    {
    }

    [ContextMenu("Menum")]
    private void Menum()
    {
        print("Ayarlardan geliyorum");
    }
}
using UnityEngine;

public class foreachdeneme : MonoBehaviour
{
    void Start()
    {
        string[] urunler = { "elma", "armut", "muz", "çilek" };
        foreach (var item in urunler)
        {
            Debug.Log(item);
        }
    }
}

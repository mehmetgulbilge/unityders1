using UnityEngine;

public class switchtunceli : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sayi = 5;

        switch (sayi)
        {
            case 1:
                Debug.Log("1");
                break;
            case 2:
                Debug.Log("2");
                break;
            case 3:
                Debug.Log("3");
                break;
            default:
                Debug.Log("Hiçbiri");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

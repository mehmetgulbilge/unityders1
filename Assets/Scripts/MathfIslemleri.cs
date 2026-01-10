using UnityEngine;

public class MathfIslemleri : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        float sayi = -12f;

        print(Mathf.Clamp(sayi, 0f, 100f));
        print(Mathf.Clamp01(sayi));
        print(Mathf.Clamp01(.5f));
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
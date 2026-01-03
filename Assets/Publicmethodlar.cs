using System.Collections;
using UnityEngine;

public class Publicmethodlar : MonoBehaviour
{
    public string ad;

    private IEnumerator birincicoroutine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        birincicoroutine = Denemem(2);
        StartCoroutine(birincicoroutine);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StopCoroutine(birincicoroutine);
        }
    }

    IEnumerator Denemem(float saniyem)
    {
        while (true)
        {
            Debug.Log("İlk yazdırmam");
            yield return new WaitForSeconds(saniyem);
            Debug.Log("İkinci yazdırmam");
        }
    }
}
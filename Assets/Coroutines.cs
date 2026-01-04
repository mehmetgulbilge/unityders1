using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Publicmethodlar : MonoBehaviour
{
    public string ad;

    private IEnumerator birincicoroutine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        birincicoroutine = Denemem(1);
        StartCoroutine(birincicoroutine);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
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
            StartCoroutine(Bensonradanoldum());
        }
    }

    IEnumerator Bensonradanoldum()
    {
        Debug.Log("Ben sonradan oldum");
        yield return null;
    }
}
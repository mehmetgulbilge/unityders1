using UnityEngine;

public class TransformIslemleri : MonoBehaviour
{
    private Vector3 pozisyonum1;

    private Vector3 pozisyonum2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        pozisyonum1 = new Vector3(1f, 2f, 1f);
        pozisyonum2 = new Vector3(1f, 2f, 1f);

        if (Equals(pozisyonum1, pozisyonum2))
            Debug.Log("Pozisyonlar eşit");
        else
            Debug.Log("Pozisyonlar eşit değil");

        if (Equals(pozisyonum1, pozisyonum2))
            Debug.Log("Pozisyonlar eşit");
        else
            Debug.Log("Pozisyonlar eşit değil");

        if (pozisyonum1 == pozisyonum2)
            Debug.Log("Pozisyonlar eşit");
        else
            Debug.Log("Pozisyonlar eşit değil");
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log(transform.position.normalized);

        // Debug.Log(Vector3.SqrMagnitude(transform.position));
        // Debug.Log(Vector3.Magnitude(transform.position));

        // transform.Translate(Vector3.back * Time.deltaTime);
        // transform.Translate(new Vector3(2f, 5f, 0f) * Time.deltaTime);
    }
}
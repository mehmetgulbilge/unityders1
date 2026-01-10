using UnityEngine;

public class Ornekobjem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(new Vector3(0, 0, 1f) * (Time.deltaTime * 10f));
    }
}
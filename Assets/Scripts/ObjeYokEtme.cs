using UnityEngine;

public class ObjeYokEtme : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        // Destroy(gameObject, 5f);
        // Destroy(this, 5f);
        Destroy(gameObject.GetComponent<CapsuleCollider>(), 2f);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
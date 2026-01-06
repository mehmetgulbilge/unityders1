using UnityEngine;

public class ObjeYakalama : MonoBehaviour
{
    private GameObject[] nesneler;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        nesneler = GameObject.FindGameObjectsWithTag("Player");

        foreach (var nesne in nesneler) nesne.GetComponent<Ilkdosyam>().Yas = 34;
        // GameObject.FindWithTag("Player").GetComponent<Rigidbody>().mass = 2;
        // GameObject.Find("Ana").GetComponent<Rigidbody>().angularDamping = 0.5f;
        // Debug.Log("Angular damping set to 0.5 for Ana object");
        //
        // GameObject.Find("Ana/Cocuk/Bebek").GetComponent<Ilkdosyam>().Yas = 34;
        // Debug.Log("Mass set to 2 for Cocuk object");
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
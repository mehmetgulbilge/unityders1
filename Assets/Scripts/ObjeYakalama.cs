using UnityEngine;

public class ObjeYakalama : MonoBehaviour
{
    public GameObject disaridan;
    private GameObject[] _nesneler;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        // Rigidbody ekle = gameObject.AddComponent<Rigidbody>();
        Rigidbody ekle = gameObject.AddComponent(typeof(Rigidbody)) as Rigidbody;
        ekle!.isKinematic = true;

        // if (gameObject.CompareTag("Player"))
        //     Debug.Log("Player");
        // else
        //     Debug.Log("Not Player");

        // gameObject.SetActive(true);
        // if (gameObject.activeSelf)
        //     Debug.Log(true);
        // else Debug.Log(false);

        // Camera cam = (Camera)FindAnyObjectByType(typeof(Camera));
        // if (cam != null)
        //     Debug.Log("Camera found: " + cam.name);
        // else
        //     Debug.Log("Camera not found");

        // Genel obje bulma
        // Rigidbody capsulum = GetComponent(typeof(Rigidbody)) as Rigidbody;
        // Rigidbody capsulum = GetComponent("Rigidbody") as Rigidbody;
        // capsulum!.mass = 3f;
        // _nesneler = GameObject.FindGameObjectsWithTag("Player");
        //
        // foreach (GameObject nesne in _nesneler)
        // {
        //     nesne.GetComponent<Ilkdosyam>().Yas = 34;
        //     Debug.Log("Yas set to 34 for " + nesne.name);
        // }

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
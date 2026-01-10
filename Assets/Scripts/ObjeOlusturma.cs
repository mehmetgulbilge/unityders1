using UnityEngine;

public class ObjeOlusturma : MonoBehaviour
{
    public GameObject prefab;
    private GameObject _parent;
    private float zaman;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        _parent = GameObject.Find("Plane");
    }

    // Update is called once per frame
    private void Update()
    {
        if (zaman >= 2)
        {
            GameObject yeni = Instantiate(prefab, transform.position, Quaternion.identity, _parent.transform);
            yeni.GetComponent<BoxCollider>().enabled = false;
            zaman = 0f;
        }
        else
        {
            zaman += Time.deltaTime;
        }
    }
}
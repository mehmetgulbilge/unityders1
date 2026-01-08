using UnityEngine;

public class TransformIslemleri : MonoBehaviour
{
    public Transform hedef;

    public Transform hedef2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        // transform.position = new Vector3(transform.position.x, 3f, transform.position.z);
        hedef.transform.Rotate(new Vector3(90f, 0f, 0f), Space.Self);
        hedef2.transform.Rotate(new Vector3(90f, 0f, 0f), Space.World);
    }

    // Update is called once per frame
    private void Update()
    {
        // transform.Translate(transform.forward * (Time.deltaTime * 2f));
        // transform.Rotate(new Vector3(2f, 0f, 0f) * (Time.deltaTime * 2f));
        hedef.transform.Rotate(new Vector3(2f, 4f, 1f) * (Time.deltaTime * 10f), Space.Self);
        hedef2.transform.Rotate(new Vector3(2f, 4f, 1f) * (Time.deltaTime * 10f), Space.World);
    }
}
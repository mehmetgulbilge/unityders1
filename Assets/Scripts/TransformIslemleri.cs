using UnityEngine;

public class TransformIslemleri : MonoBehaviour
{
    public Transform hedef;

    public Transform hedef2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        // transform.position = new Vector3(transform.position.x, 3f, transform.position.z);
        // hedef.transform.Rotate(new Vector3(90f, 0f, 0f), Space.Self);
        // hedef2.transform.Rotate(new Vector3(90f, 0f, 0f), Space.World);


        // GameObject aramasonuc = transform.Find("GameObject").gameObject;
        // aramasonuc.name = "Bulundum";
        //
        // Debug.Log(transform.childCount);
        // Debug.Log(transform.hierarchyCount);

        int childCount = transform.childCount;

        for (int i = 0; i < childCount; i++) Debug.Log(transform.GetChild(i).name);
    }

    // Update is called once per frame
    private void Update()
    {
        // hedef2.transform.LookAt(hedef.position);
        // transform.Translate(transform.forward * (Time.deltaTime * 2f));
        // transform.Rotate(new Vector3(2f, 0f, 0f) * (Time.deltaTime * 2f));
        // hedef.transform.Rotate(new Vector3(2f, 4f, 1f) * (Time.deltaTime * 10f), Space.Self);
        // hedef2.transform.Rotate(new Vector3(2f, 4f, 1f) * (Time.deltaTime * 10f), Space.World);
    }
}
using UnityEngine;

public class TransformIslemleri : MonoBehaviour
{
    public Transform hedef;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        // transform.rotation = Quaternion.Euler(0f, 45f, 0f);

        // transform.rotation = Quaternion.FromToRotation(Vector3.up, Vector3.forward);

        transform.rotation = Quaternion.identity;

        // if (parent && child) child.transform.SetParent(parent);

        // transform.position = new Vector3(transform.position.x, 3f, transform.position.z);
        // hedef.transform.Rotate(new Vector3(90f, 0f, 0f), Space.Self);
        // hedef2.transform.Rotate(new Vector3(90f, 0f, 0f), Space.World);


        // GameObject aramasonuc = transform.Find("GameObject").gameObject;
        // aramasonuc.name = "Bulundum";
        //
        // Debug.Log(transform.childCount);
        // Debug.Log(transform.hierarchyCount);

        // int childCount = transform.childCount;
        //
        // for (int i = 0; i < childCount; i++) Debug.Log(transform.GetChild(i).name);
    }

    // Update is called once per frame
    private void Update()
    {
        // Vector3 fark = hedef.position - transform.position;

        // hedef.rotation = Quaternion.LookRotation(fark, Vector3.up);

        // float angle = Quaternion.Angle(hedef.rotation, transform.rotation);
        // print(angle);

        // hedef.rotation = Quaternion.Inverse(transform.rotation);

        // hedef2.transform.LookAt(hedef.position);
        // transform.Translate(transform.forward * (Time.deltaTime * 2f));
        // transform.Rotate(new Vector3(2f, 0f, 0f) * (Time.deltaTime * 2f));
        // hedef.transform.Rotate(new Vector3(2f, 4f, 1f) * (Time.deltaTime * 10f), Space.Self);
        // hedef2.transform.Rotate(new Vector3(2f, 4f, 1f) * (Time.deltaTime * 10f), Space.World);
    }
}
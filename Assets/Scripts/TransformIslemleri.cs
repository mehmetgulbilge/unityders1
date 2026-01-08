using UnityEngine;

public class TransformIslemleri : MonoBehaviour
{
    public Transform hedef;

    public Transform hedef2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        /*
         * Distance
         */
        // float distance = Vector3.Distance(hedef.position, transform.position);
        // Debug.Log(distance);

        /*
         * Angle
         */
        // Vector3 mesafe = hedef.position - transform.position;

        // float angle = Vector3.Angle(mesafe, transform.forward);
        //
        // Debug.Log(angle);
        //
        // if (angle < 5f) Debug.Log("Angle is less than 5 degrees");
    }
}
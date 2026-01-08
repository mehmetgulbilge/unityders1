using UnityEngine;

public class TransformIslemleri : MonoBehaviour
{
    public Transform hedef;

    public Transform hedef2;

    private float BaslangicZamani;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        BaslangicZamani = Time.time;

        Vector3 birincipoz = new(4f, 2f, 3f);
        Vector3 ikinciPoz = new(1f, 2f, 5f);

        // print(Vector3.Max(birincipoz, ikinciPoz));
        // print(Vector3.Min(birincipoz, ikinciPoz));
        // print(Vector3.Scale(birincipoz, ikinciPoz));
        print(birincipoz - ikinciPoz);
        print(birincipoz + ikinciPoz);
        print(birincipoz * 2f);
        print(birincipoz / 2f);
    }

    // Update is called once per frame
    private void Update()
    {
        // transform.position = Vector3.Lerp(transform.position, hedef.position, (Time.time - BaslangicZamani) * 3f);

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
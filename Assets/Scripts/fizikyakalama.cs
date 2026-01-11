using UnityEngine;

public class fizikyakalama : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name);
    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log("Collision ended with: " + other.gameObject.name);
    }

    private void OnCollisionStay(Collision other)
    {
        Debug.Log("Collision ongoing with: " + other.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered with: " + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger exited with: " + other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger ongoing with: " + other.gameObject.name);
    }
}
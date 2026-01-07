using UnityEngine;

public class Mesaj : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        gameObject.SendMessage("MesajGonder");
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void MesajGonder()
    {
        Debug.Log("Mesaj gönderildi");
    }
}
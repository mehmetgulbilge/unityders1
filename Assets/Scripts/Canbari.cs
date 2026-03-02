using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Canbari : MonoBehaviour
{
    Image image;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        image = (Image)GameObject.Find("Canvas/Image").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            image.fillAmount -= 0.1f;
        }
    }

    public void candusur()
    {
        image.fillAmount -= 0.1f;
    }
    
    public void dropwdownSelected(int index)
    {
        Debug.Log(index);
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class KarakterScriptim : MonoBehaviour
{
    
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            animator.SetBool("yuru_p", true);
        }
    }
}

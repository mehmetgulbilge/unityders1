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
        else if (Keyboard.current.wKey.wasReleasedThisFrame)
        {
            animator.SetBool("yuru_p", false);
        }
        
        if (Keyboard.current.shiftKey.wasPressedThisFrame)
        {
            animator.SetBool("kos_p", true);
            
            if (Keyboard.current.ctrlKey.wasPressedThisFrame)
            {
                animator.SetBool("depar_p", true);
            }
        }
        
        
        if (Keyboard.current.ctrlKey.wasReleasedThisFrame)
        {
            animator.SetBool("depar_p", false);
        }
        
        else if (Keyboard.current.shiftKey.wasReleasedThisFrame)
        {
            animator.SetBool("kos_p", false);
        }
        
        if (Keyboard.current.altKey.wasReleasedThisFrame)
        {
            animator.SetBool("kos_p", false);
        }
        
        
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            animator.SetBool("zipla_p", true);
        }
        else if (Keyboard.current.spaceKey.wasReleasedThisFrame)
        {
            animator.SetBool("zipla_p", false);
        }
    }
}

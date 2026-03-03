using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationControl : MonoBehaviour
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
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            animator.SetBool( "gez", true);
        }
        if (Keyboard.current.cKey.wasPressedThisFrame)
        {
            animator.SetBool( "gez", false);
        }
    }
}

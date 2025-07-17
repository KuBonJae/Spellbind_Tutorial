using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveAnimation : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void MovePlayer(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        if (input != Vector2.zero)
            animator.SetFloat("MoveSpeed", 1f);
        else
            animator.SetFloat("MoveSpeed", 0f);

        if (animator.GetLayerWeight(2) < 1f)
        {
            //animator.SetLayerWeight(0, animator.GetLayerWeight(0) - 0.06f);
            animator.SetLayerWeight(2, animator.GetLayerWeight(2) + 0.06f);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodMorning : MonoBehaviour
{
    public Animator animator;

    void OnEnable()
    {
        animator.SetTrigger("GetUp");
    }
}

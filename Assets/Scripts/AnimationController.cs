using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0;
    private Animator _animator;

    // _animator ���� 
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        animationVariable = (animationVariable + 1) % 3;
        // animationVariable�� ����
        _animator.SetInteger("State", animationVariable);
    }
}
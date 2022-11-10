using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    // ����� ���� Animator
    private Animator anim;

    public const string WalkParameter = "Walk";
    public const string RunParameter = "Run";
    public const string AttackParameter = "Attack";
    public const string DeadParameter = "Dead";
    void Awake()
    {
        // �������� Animator � ����� �������� ��� ����� anim
        anim = GetComponent<Animator>();
    }

    // ������������ �������� ��� ��������� Walk 
    public void Walk(bool walk)
    {
        anim.SetBool(WalkParameter, walk);
    }

    // ������������ �������� ��� ��������� Run
    public void Run(bool run)
    {
        anim.SetBool(RunParameter, run);
    }

    // ������������ �������� ��� ��������� Attack
    public void Attack()
    {
        anim.SetTrigger(AttackParameter);
    }

    // ������������ �������� ��� ��������� Dead
    public void Dead()
    {
        anim.SetTrigger(DeadParameter);
    }


}

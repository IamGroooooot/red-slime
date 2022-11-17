using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private string mName;
    private Animator animator;
    private ICommand altButtonCommand;
    private ICommand spaceButtonCommand;

    void Start()
    {
        this.mName = this.gameObject.name;
        this.animator = this.GetComponent<Animator>();

        this.altButtonCommand = new AttackCommand(this);
        this.spaceButtonCommand = new JumpCommand(this);

        Debug.Log("Monster " + this.mName + " is created!");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.spaceButtonCommand.Execute();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            this.altButtonCommand.Execute();
        }
    }

    public void attack(){
        this.animator.SetTrigger("doAttackTrigger");
    }

    public void jump(){
        this.animator.SetTrigger("doJumpTrigger");
    }
}

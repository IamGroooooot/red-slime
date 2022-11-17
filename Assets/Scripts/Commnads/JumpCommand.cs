using UnityEngine;

public class JumpCommand : ICommand
{
    Animator animator;
    Monster monster;
    
    public JumpCommand(Monster monster)
    {
        this.monster = monster;
    }

    
    public void Execute()
    {
        monster.jump();
    }
}

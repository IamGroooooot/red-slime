using UnityEngine;

public class AttackCommand : ICommand
{
    Monster monster;

    public AttackCommand(Monster monster)
    {
        this.monster = monster;
    }

    public void Execute()
    {
        monster.attack();
    }
}

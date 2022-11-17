using UnityEngine;

public class PopupCommand : ICommand
{
    GameManager gameManager;
    public PopupCommand(GameManager gameManager)
    {
        this.gameManager = gameManager;
    }

    public void Execute()
    {
        Debug.Log("PopupCommand!");
    }
}

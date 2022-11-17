using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject settingPanel;

    void Start()
    {
        this.settingPanel.SetActive(false);    
    }

    public void OnSettingButtonClicked()
    {
        ExecuteCommand(new ToggleSettingPopUpCommand(this.settingPanel));
    }
    
    public void OpenSettings()
    {
        ExecuteCommand(new OpenSettingCommand(this.settingPanel));
    }
    
    public void CloseSettings()
    {
        ExecuteCommand(new CloseSettingCommand(this.settingPanel));
    }

    private static void ExecuteCommand(ICommand command)
    {
        command.Execute();
    }
}

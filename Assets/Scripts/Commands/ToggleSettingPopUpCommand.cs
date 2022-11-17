using UnityEngine;

public class ToggleSettingPopUpCommand : ICommand
{
    private GameObject _settingPanel;

    public  ToggleSettingPopUpCommand(GameObject settingPanel)
    {
        this._settingPanel = settingPanel;
    }

    public void Execute()
    {
        this._settingPanel.SetActive(!this._settingPanel.activeSelf);
    }
}

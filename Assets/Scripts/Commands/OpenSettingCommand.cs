using UnityEngine;

public class OpenSettingCommand : ICommand
{
    private GameObject _settingPanel;

    public OpenSettingCommand(GameObject settingPanel)
    {
        this._settingPanel = settingPanel;
    }

    public void Execute()
    {
        this._settingPanel.SetActive(true);
    }
}

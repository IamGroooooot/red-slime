using UnityEngine;

public class CloseSettingCommand : ICommand
{
    private GameObject _settingPanel;

    public CloseSettingCommand(GameObject settingPanel)
    {
        this._settingPanel = settingPanel;
    }

    public void Execute()
    {
        this._settingPanel.SetActive(false);
    }
}

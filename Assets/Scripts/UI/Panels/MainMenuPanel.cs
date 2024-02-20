using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPanel : Panel
{
    public override void Show(string param)
    {
        Setup(true);
        base.Show();

    }

    public override void Hide()
    {
        Setup(false);
    }

    public override string GetPreviousPanelName()
    {
        return "";
    }

    private void Setup(bool show)
    {
        //UIControllers.instance.mainPanel.SetActive(show);
    }
}

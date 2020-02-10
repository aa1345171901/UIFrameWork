using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPanel : BasePanel
{
    CanvasGroup canvasGroup;

    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }
    
    /// <summary>
    /// 暂停时不能与鼠标交互
    /// </summary>
    public override void OnPause()
    {
        canvasGroup.blocksRaycasts = false;
    }

    /// <summary>
    /// 恢复交互
    /// </summary>
    public override void OnResume()
    {
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPushClick(string uiPanelType)
    {
        UIPanelType panelType = (UIPanelType)Enum.Parse(typeof(UIPanelType), uiPanelType);
        UIManager.Instance.PushPanel(panelType);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskPanel : BasePanel
{
    public override void OnEnter()
    {
        this.gameObject.SetActive(true);
    }

    public override void OnExit()
    {
        this.gameObject.SetActive(false);
    }

    public void OnCloseClick()
    {
        UIManager.Instance.PopPanel();
    }
}

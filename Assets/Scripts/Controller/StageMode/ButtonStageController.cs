using LTAUnityBase.Base.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStageController : ButtonController
{
    private void Start()
    {
        this.OnClick(OnClickUpgrade);
    }

    void OnClickUpgrade(ButtonController btn)
    {
       
        SceneController.OpenSubScene(AllSceneName.GamePlay);
    }
}

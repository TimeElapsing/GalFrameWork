///=====================================================
/// - FileName:      UICustomOption.cs
/// - NameSpace:     YukiFrameWork.Dialogue
/// - Description:   通过本地的代码生成器创建的脚本
/// - Creation Time: 2024/7/19 14:39:43
/// -  (C) Copyright 2008 - 2024
/// -  All Rights Reserved.
///=====================================================
using YukiFrameWork;
using UnityEngine;
using System;
using Sirenix.OdinInspector;
using UnityEngine.UI;
namespace YukiFrameWork.DiaLogue
{
	public class UICustomOption : UIOption
	{
        [SerializeField, LabelText("设置按钮")]
        internal Button onClickBtn;

        [LabelText("设置与按钮配套的文本"), SerializeField]
        internal Text mTextContext;    

        public override void InitUIOption(DiaLog diaLog, Node node)
        {
            mTextContext.text = Option.optionTexts;
            onClickBtn.onClick.RemoveAllListeners();
            onClickBtn.onClick.AddListener(ButtonClick);
            void ButtonClick()
            {
                diaLog.MoveNextByOption(Option);
            }
        }
    }
}

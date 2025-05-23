///=====================================================
/// - FileName:      Main.cs
/// - NameSpace:     GalGame
/// - Description:   高级定制脚本生成
/// - Creation Time: 2025/5/23 7:15:09
/// -  (C) Copyright 2008 - 2025
/// -  All Rights Reserved.
///=====================================================
using YukiFrameWork;
using UnityEngine;
using System;
using YukiFrameWork.UI;
using GalGame.UI;
namespace GalGame
{
    public class Main : ViewController
    {

        private async void Awake()
        {
            UIKit.ShowPanel<LoadingPanel>();
            //等待启动框架
            await GalGame.StartUp();

            //TODO 加载场景

            UIKit.HidePanel<LoadingPanel>();
        }
    }
}

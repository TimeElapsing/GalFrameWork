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
using YukiFrameWork.Machine;
using XFABManager;
namespace Nickings
{
    public class Main : ViewController
    {
        protected async override void Awake()
        {
            //打开加载UI显示
            // UIKit.ShowPanel<LoadingPanel>();

            //等待启动框架
            await Nickings.StartUp();
            

            //AB包加载场景管理器，并在场景中创建出
            var core = await AssetBundleManager.LoadAssetAsync<RuntimeStateMachineCore>(Nickings.ProjectName, "Game");
            StateManager.StartMachine("Game", core, typeof(Nickings));
        }
    }
}

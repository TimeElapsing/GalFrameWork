///=====================================================
/// - FileName:      GalGame.cs
/// - NameSpace:     GalGame
/// - Description:   高级定制脚本生成
/// - Creation Time: 2025/5/23 7:12:46
/// -  (C) Copyright 2008 - 2025
/// -  All Rights Reserved.
///=====================================================
using YukiFrameWork;
using UnityEngine;
using System;
using YukiFrameWork.UI;
using YukiFrameWork.Missions;
using YukiFrameWork.Audio;
using GalGame.Loader;
namespace GalGame
{
    public class GalGame : Architecture<GalGame>
    {

        //可以填写默认进入的场景名称，在架构准备完成后，自动进入
        public override (string, SceneLoadType) DefaultSceneName => default;
        public override string OnProjectName => base.OnProjectName;

        public override void OnInit()
        {
            //初始化架构

            //此处需要进行ab包的一些配置，所以先暂缓
            //TODO：ab包配置之后恢复
            // MissionKit.Init(ProjectName);
            // UIKit.Init(ProjectName);
            // SceneTool.XFABManager.Init(ProjectName);
            // AudioKit.Init(ProjectName);

            //本地加载初始化
            MissionKit.Init(new MyMissionLoader());
            UIKit.Init(new MyUIConfigLoader());
            AudioKit.Init(new MyAduioLoaderPools());

        }


        //配表构建，通过ArchitectureTable可以在架构中缓存部分需要的资源,例如TextAssets ScriptableObject
        protected override ArchitectureTable BuildArchitectureTable() => default;

        //当架构准备完成后触发，当架构加载失败抛出异常则不会执行
        public override void OnCompleted()
        {

        }


    }

}

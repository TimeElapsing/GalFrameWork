///=====================================================
/// - FileName:      MyUILoader.cs
/// - NameSpace:     GalGame.Loader
/// - Description:   框架自定ViewController
/// - Creation Time: 2025/5/23 7:51:47
/// -  (C) Copyright 2008 - 2025
/// -  All Rights Reserved.
///=====================================================
using YukiFrameWork;
using UnityEngine;
using System;
using YukiFrameWork.UI;
namespace Nickings.Loader
{
    public partial class MyUIConfigLoader : IUIConfigLoader
    {
        public TItem Load<TItem>(string name) where TItem : BasePanel
        {
            return Resources.Load<TItem>(name);
        }

        public void LoadAsync<TItem>(string name, Action<TItem> onCompleted) where TItem : BasePanel
        {
            var result = Resources.LoadAsync<TItem>(name);

            result.completed += opertaion =>
            {
                if (opertaion.isDone)
                    onCompleted?.Invoke(result.asset as TItem);
            };
        }

        public void UnLoad(BasePanel item)
        {
            Resources.UnloadAsset(item);
        }
    }
}

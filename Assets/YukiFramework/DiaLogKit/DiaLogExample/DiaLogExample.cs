///=====================================================
/// - FileName:      DiaLogDebugger.cs
/// - NameSpace:     YukiFrameWork.DiaLog
/// - Description:   通过本地的代码生成器创建的脚本
/// - Creation Time: 2024/4/30 0:12:54
/// -  (C) Copyright 2008 - 2024
/// -  All Rights Reserved.
///=====================================================
using YukiFrameWork;
using UnityEngine;
using System;
using Sirenix.OdinInspector;
using YukiFrameWork.DiaLogue;
namespace YukiFrameWork.DiaLogue
{
	public class DiaLogExample : MonoBehaviour
	{
		private UIDiaLog diaLog;
        private DiaLog d;
        private void Awake()
        {
            DiaLogKit.Init(new ICustomDiaLogueLoader());
            diaLog = GetComponent<UIDiaLog>();
            d = DiaLogKit.CreateDiaLogue("Example","NodeTree");
            DiaLogKit.Bind(d,diaLog);
            diaLog.Auto_Reset_MoveNext();
        }

        private void Start()
        {
            d.RegisterWithNodeExitEvent(node => 
            {
                node.GetContext().LogInfo();
            });
            
            d.RegisterNextFailedEvent(async () =>
            {
                LogKit.W("节点结束两秒后重新开始");
                await CoroutineTool.WaitForSeconds(2);
                d.MoveNode(d.GetRootNode());             
                diaLog.Auto_Reset_MoveNext();
                        
            });
        }
    }

    public class ICustomDiaLogueLoader : IDiaLogLoader
    {
        public TItem Load<TItem>(string name) where TItem : NodeTree
        {
            return Resources.Load<TItem>(name);
        }

        public void LoadAsync<TItem>(string name, Action<TItem> onCompleted) where TItem : NodeTree
        {
            var operation = Resources.LoadAsync<TItem>(name);

            operation.completed += v => 
            {
                onCompleted?.Invoke(operation.asset as TItem);
            };
        }

        public void UnLoad(NodeTree item)
        {
            
        }
    }
}

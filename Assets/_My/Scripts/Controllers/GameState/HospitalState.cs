///=====================================================
/// - FileName:      HospitalState.cs
/// - NameSpace:     Nickings
/// - Description:   YUKI 有限状态机构建状态类
/// - Creation Time: 2025/5/27 10:41:55
/// -  (C) Copyright 2008 - 2025
/// -  All Rights Reserved.
///=====================================================
using YukiFrameWork.Machine;
using UnityEngine;
using YukiFrameWork;
using YukiFrameWork.UI;
using Nickings.UI;
using System.Threading.Tasks;
namespace Nickings
{
	public class HospitalState : StateBehaviour
	{
		public override async void OnEnter()
		{
			
			UIKit.ShowPanel<LoadingPanel>();
			await SceneTool.XFABManager.LoadSceneAsync("Hospital");
			UIKit.HidePanel<LoadingPanel>();
		}
		public override void OnUpdate()
		{
			
			Debug.Log("状态每帧更新");
		}
		public override void OnExit()
		{
			Debug.Log("当退出状态");
		}

	}
}

///=====================================================
/// - FileName:      GamingState.cs
/// - NameSpace:     Nickings
/// - Description:   YUKI 有限状态机构建状态类
/// - Creation Time: 2025/5/25 11:36:44
/// -  (C) Copyright 2008 - 2025
/// -  All Rights Reserved.
///=====================================================
using YukiFrameWork.Machine;
using UnityEngine;
using YukiFrameWork;
namespace Nickings
{
	public class GamingState : StateBehaviour
	{
		public override void OnInit()
		{
			Debug.Log("当状态初始化");
		}
		public override void OnEnter()
		{
			Debug.Log("当进入状态");
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

///=====================================================
/// - FileName:      InitState.cs
/// - NameSpace:     GalGame
/// - Description:   YUKI 有限状态机构建状态类
/// - Creation Time: 2025/5/25 10:12:19
/// -  (C) Copyright 2008 - 2025
/// -  All Rights Reserved.
///=====================================================
using YukiFrameWork.Machine;
using UnityEngine;
using YukiFrameWork;
using System.Threading.Tasks;
using YukiFrameWork.UI;
using Nickings.UI;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;
namespace Nickings
{
	public class InitState : StateBehaviour
	{
		public override  void OnEnter()
		{
		 	SceneTool.XFABManager.LoadScene("MainMenu");
		}
		public override void OnUpdate()
		{
			if (SceneManager.GetActiveScene().name != "Init")
			{
				SetTrigger("InitFinish");
			}
		}
		public override void OnExit()
		{
			UIKit.HidePanel<LoadingPanel>();
		}

	}
}

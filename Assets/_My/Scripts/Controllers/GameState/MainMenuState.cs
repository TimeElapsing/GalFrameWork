///=====================================================
/// - FileName:      MainMenuState.cs
/// - NameSpace:     Nickings
/// - Description:   YUKI 有限状态机构建状态类
/// - Creation Time: 2025/5/26 8:28:51
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
	public class MainMenuState : StateBehaviour
	{
		public override async void OnEnter()
		{
			base.OnEnter();

			UIKit.ShowPanel<LoadingPanel>();
			await SceneTool.XFABManager.LoadSceneAsync("MainMenu");
			UIKit.HidePanel<LoadingPanel>();


			var mainMenuPanel = UIKit.OpenPanel<MainMenuPanel>();
			mainMenuPanel.OnClickStart(() =>
			{
				 SetInt("GameState", (int)GameState.Hospital);
				 UIKit.ClosePanel<MainMenuPanel>();
			});
			mainMenuPanel.OnClickOptions(() => { Debug.Log("点击了选项"); });
			mainMenuPanel.OnClickExit(() =>
			{
				Debug.Log("点击了退出");
#if UNITY_EDITOR
				UnityEditor.EditorApplication.isPlaying = false;
#else
				Application.Quit();
#endif
			});
		}
		public override void OnExit()
		{
			Debug.Log("当退出状态");
		}

	}
}

///=====================================================
/// - FileName:      GlobalState.cs
/// - NameSpace:     Nickings
/// - Description:   YUKI 有限状态机构建状态类
/// - Creation Time: 2025/5/27 7:49:02
/// -  (C) Copyright 2008 - 2025
/// -  All Rights Reserved.
///=====================================================
using YukiFrameWork.Machine;
using UnityEngine;
using YukiFrameWork;
using Nickings.Models;
using YukiFrameWork.InputSystemExtension;
using UnityEngine.InputSystem;
using YukiFrameWork.UI;
using Nickings.UI;
using System.Collections;
namespace Nickings
{
	public class GlobalState : StateBehaviour
	{
		private IInputModel inputModel;

		public override void OnInit()
		{
			inputModel = this.GetModel<IInputModel>();
		}
		public override void OnEnter()
		{
			inputModel.Enable();

			inputModel.Options.onKeyDown += OnOptionsKeyDown;
			inputModel.Test.onKeyDown += OnTestKeyDown;


		}


		private void OnOptionsKeyDown(InputAction.CallbackContext context, InputKeyControl keyControl)
		{
			Debug.Log("按下了选项键");


		}
		private void OnTestKeyDown(InputAction.CallbackContext context, InputKeyControl inputKeyControl)
		{
			Debug.Log("按下了测试键");
			if (UIKit.IsPanelActive<TestPanel>())
			{
				UIKit.HidePanel<TestPanel>();
				return;
			}
			var panel = UIKit.ShowPanel<TestPanel>();
			panel.OnClickMainMenu(() =>
			{
				 SetInt("GameState", (int)GameState.MainMenu);
				 UIKit.HidePanel<TestPanel>();
			});
		}


		public override void OnExit()
		{
			inputModel.Options.onKeyDown -= OnOptionsKeyDown;
			inputModel.Test.onKeyDown -= OnTestKeyDown;
		}

	}
}

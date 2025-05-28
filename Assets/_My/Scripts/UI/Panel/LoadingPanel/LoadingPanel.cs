///=====================================================
/// - FileName:      LoadingPanel.cs
/// - NameSpace:     GalGame.UI
/// - Description:   框架自定BasePanel
/// - Creation Time: 2025/5/23 8:21:00
/// -  (C) Copyright 2008 - 2025
/// -  All Rights Reserved.
///=====================================================
using Nickings.Models;
using YukiFrameWork;
using YukiFrameWork.UI;
namespace Nickings.UI
{
	public partial class LoadingPanel : BasePanel
	{
		private IInputModel inputModel;

		public override void OnPreInit(params object[] param)
		{
			base.OnPreInit(param);
			if (param == null || param.Length == 0)
			{
				LogKit.E("LoadingPanel预初始化失败，参数不能为空");
				return;
			}
			if (param[0] is IInputModel model)
			{
				inputModel = model;
			}
        }

		public override void OnEnter(params object[] param)
		{
			base.OnEnter(param);

			//禁用玩家输入
			inputModel?.Disable();
		}
		public override void OnExit()
		{
			base.OnExit();

			//启用玩家输入
			inputModel?.Enable();
		}

	}
}

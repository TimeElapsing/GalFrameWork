///=====================================================
/// - FileName:      MainMenuPanel.cs
/// - NameSpace:     Nickings.UI
/// - Description:   框架自定BasePanel
/// - Creation Time: 2025/5/26 8:42:12
/// -  (C) Copyright 2008 - 2025
/// -  All Rights Reserved.
///=====================================================
using YukiFrameWork.UI;
using UnityEngine;
using YukiFrameWork;
using UnityEngine.UI;
using System;
using UnityEngine.Events;
namespace Nickings.UI
{
	public partial class MainMenuPanel : BasePanel
	{
		public override void OnInit()
		{
			base.OnInit();
		}
		public override void OnEnter(params object[] param)
		{
			base.OnEnter(param);
		}
		public override void OnPause()
		{
			base.OnPause();
		}
		public override void OnResume()
		{
			base.OnResume();
		}
		public override void OnExit()
		{
			base.OnExit();
		}

		#region 点击事件

		public void OnClickStart(UnityAction action) => Start.GetComponent<Button>().AddListenerPure(action);
		public void OnClickOptions(UnityAction action) => Options.GetComponent<Button>().AddListenerPure(action);
		public void OnClickExit(UnityAction action) => Exit.GetComponent<Button>().AddListenerPure(action);

		#endregion
	}
}

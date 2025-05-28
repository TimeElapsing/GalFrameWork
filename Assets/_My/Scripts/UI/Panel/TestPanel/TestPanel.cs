///=====================================================
/// - FileName:      TestPanel.cs
/// - NameSpace:     Nickings.UI
/// - Description:   框架自定BasePanel
/// - Creation Time: 2025/5/27 10:20:11
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
	public partial class TestPanel : BasePanel
	{
		public void OnClickMainMenu(UnityAction action) => MainMenu.GetComponent<Button>().AddListenerPure(action);
	}
}

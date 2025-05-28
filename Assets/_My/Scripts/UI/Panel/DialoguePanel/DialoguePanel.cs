///=====================================================
/// - FileName:      DialoguePanel.cs
/// - NameSpace:     Nickings.UI
/// - Description:   框架自定BasePanel
/// - Creation Time: 2025/5/27 22:14:38
/// -  (C) Copyright 2008 - 2025
/// -  All Rights Reserved.
///=====================================================
using YukiFrameWork.UI;
using UnityEngine;
using YukiFrameWork;
using UnityEngine.UI;
using TMPro;
namespace Nickings.UI
{
	public partial class DialoguePanel : BasePanel
	{
		public override void OnInit()
		{
			base.OnInit();
		}
		public override void OnEnter(params object[] param)
		{
			base.OnEnter(param);

		}

		public override void OnExit()
		{
			base.OnExit();
		}
		
		private void UpdateDialogue(string name, string dialogue)
		{
			if (Name != null)
			{
				Name.text = name;
			}
			if (Dialogue != null)
			{
				Dialogue.text = dialogue;
			}
		}

	}
}

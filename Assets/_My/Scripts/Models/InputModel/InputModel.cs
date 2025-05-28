///=====================================================
/// - FileName:      InputModel.cs
/// - NameSpace:     Nickings.Models
/// - Description:   高级定制脚本生成
/// - Creation Time: 2025/5/27 8:14:39
/// -  (C) Copyright 2008 - 2025
/// -  All Rights Reserved.
///=====================================================
using YukiFrameWork;
using UnityEngine;
using System;
using YukiFrameWork.InputSystemExtension;
namespace Nickings.Models
{
    public interface IInputModel : IModel, IDisposable
    {
        //输入控制组
        InputControlGroup DialogueControl { get; }
        InputControlGroup Options { get; }
        InputControlGroup Test { get; }

        void Enable();
        void Disable();

        void InputRebindAddListener(Action callback);
        void InputRebindRemoveListener(Action callback);
    }


    [Registration(typeof(Nickings),typeof(IInputModel))]
    public class InputModel : AbstractModel,IInputModel
    {
        //Unity新输入系统的配置
        private InputActions inputActions;

        public const int DialogueNextIndex = 1;
        public const int OptionsIndex = 1;


        public InputControlGroup DialogueControl => InputControlGroup.GetInputControlGroup(inputActions.Player.Dialogue.name);
        public InputControlGroup Options => InputControlGroup.GetInputControlGroup(inputActions.Player.Options.name);
        public InputControlGroup Test => InputControlGroup.GetInputControlGroup(inputActions.Player.Test.name);

        public override void Init()
        {
            inputActions = new InputActions();
            InputControlGroup.CreateInputControlGroupsByInputAction(inputActions.Player);
        }

        public override void Destroy()
        {
            Dispose();
        }
        public void Dispose()
        {
            DialogueControl?.Dispose();
            Options?.Dispose();
            Test?.Dispose();
        }

        public void Enable()
        {
            DialogueControl?.Enable();
            Options?.Enable();
            Test?.Enable();
        }

        public void Disable()
        {
            DialogueControl?.Disable();
            Options?.Disable();
            Test?.Disable();
        }

        public void InputRebindAddListener(Action callback)
        {
            DialogueControl.onBindRebind += callback;
            Options.onBindRebind += callback;
        }

        public void InputRebindRemoveListener(Action callback)
        {
            DialogueControl.onBindRebind -= callback;
            Options.onBindRebind -= callback;
        }

    }
}

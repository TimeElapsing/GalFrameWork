///=====================================================
/// - FileName:      MyAudioLoader.cs
/// - NameSpace:     GalGame.Loader
/// - Description:   框架自定ViewController
/// - Creation Time: 2025/5/23 7:52:19
/// -  (C) Copyright 2008 - 2025
/// -  All Rights Reserved.
///=====================================================
using YukiFrameWork;
using UnityEngine;
using System;
using YukiFrameWork.Audio;
namespace Nickings.Loader
{
	public partial class MyAudioLoader : IAudioLoader
	{
		private AudioClip mClip;
		public AudioClip Clip => mClip;

		public AudioClip LoadClip(string path)
		{
			mClip = Resources.Load<AudioClip>(path);
			return mClip;
		}

		public void LoadClipAsync(string path, Action<AudioClip> completedLoad)
		{
			var result = Resources.LoadAsync<AudioClip>(path);
			result.completed += operation =>
			{
				if (operation.isDone)
					completedLoad?.Invoke(result.asset as AudioClip);
			};
		}

		public void UnLoad()
		{
			Resources.UnloadAsset(mClip);
		}
	}
	
	public class MyAduioLoaderPools : IAudioLoaderPools
	{
        public IAudioLoader CreateAudioLoader()
        {
            return new MyAudioLoader();
        }
    }
}

using System;
using System.Collections.Generic;
using Raylib_cs;

namespace Naiya
{
	public class NaiyaGame : IDisposable
	{
		#region Methods
		public void Run()
		{
			// create window, etc.
			PreInit();
			Raylib.InitWindow(ScreenWidth, ScreenHeight, "");

			if (Scenes.Count == 0)
			{
				Scenes.Add(new NaiyaScene()); // add default scene if there are none already
			}
			Scenes[SceneIndex].Enable();

			while (!Raylib.WindowShouldClose())
			{
				Scenes[SceneIndex].Update();

				Raylib.BeginDrawing();
				{
					Scenes[SceneIndex].Draw();
				}
				Raylib.EndDrawing();
			}
		}

		public void Dispose()
		{
			Scenes[SceneIndex].Disable();
			Raylib.CloseWindow();
		}

		public void AddScene(NaiyaScene scene)
		{
			Scenes.Add(scene);
		}

		public void SwapToScene(int index)
		{
			Scenes[SceneIndex].Disable();
			SceneIndex = index;
			Scenes[SceneIndex].Enable();
		}
		#endregion

		#region Virtual Methods
		protected virtual void PreInit() // for setting flags and window dimensions, etc.
		{

		}
		#endregion

		#region Properties
		// window properties
		protected int ScreenWidth { get; set; } = 640;
		protected int ScreenHeight { get; set; } = 480;
		protected ConfigFlags ConfigFlags { get; set; } = ConfigFlags.FLAG_WINDOW_HIGHDPI;

		// scene properties
		protected List<NaiyaScene> Scenes = new List<NaiyaScene>();
		protected int SceneIndex = 0;
		#endregion
	}
}

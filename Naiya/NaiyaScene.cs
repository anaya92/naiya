using System;
using Raylib_cs;

namespace Naiya
{
	public class NaiyaScene
	{
		#region Methods
		public void Enable()
		{
			Enabled = true;
			OnEnable();
		}

		public void Disable()
		{
			OnDisable();
			Enabled = false;
		}
		#endregion

		#region Virtual Methods
		protected virtual void OnEnable()
		{
			Window.Title = "naiya game";
		}

		public virtual void Update()
		{

		}

		public virtual void Draw()
		{
			Raylib.ClearBackground(Color.MAROON);
			Raylib.DrawText("anaya's c# game engine :)", 10, 10, 24, Color.WHITE);
		}

		protected virtual void OnDisable()
		{

		}
		#endregion

		#region Properties
		// window stuff
		protected static class Window
		{
			static public bool IsReady
			{
				get
				{
					return Raylib.IsWindowReady();
				}
			}

			static public bool IsFullscreen
			{
				get
				{
					return Raylib.IsWindowFullscreen();
				}
			}

			static public bool IsHidden
			{
				get
				{
					return Raylib.IsWindowHidden();
				}
			}

			static public bool IsMinimized
			{
				get
				{
					return Raylib.IsWindowMinimized();
				}
			}

			static public bool IsMaximized
			{
				get
				{
					return Raylib.IsWindowMaximized();
				}
			}

			static public bool IsFocused
			{
				get
				{
					return Raylib.IsWindowFocused();
				}
			}

			static public bool IsResized
			{
				get
				{
					return Raylib.IsWindowResized();
				}
			}

			static public string Title
			{
				set
				{
					Raylib.SetWindowTitle(value);
				}
			}

			static public ConfigFlags State
			{
				set
				{
					Raylib.SetWindowState(value);
				}
			}

			static public (int, int) Dimensions
			{
				get
				{
					return (Raylib.GetScreenWidth(), Raylib.GetScreenHeight());
				}

				set
				{
					Raylib.SetWindowSize(value.Item1, value.Item2);
				}
			}

			static public (int, int) MinimumDimensions
			{
				set
				{
					Raylib.SetWindowMinSize(value.Item1, value.Item2);
				}
			}

			static public (int, int) Position
			{
				get
				{
					var pos = Raylib.GetWindowPosition();
					return ((int) pos.X, (int) pos.Y);
				}
				set
				{
					Raylib.SetWindowPosition(value.Item1, value.Item2);
				}
			}

			static public int CurrentMonitor
			{
				set
				{
					Raylib.SetWindowMonitor(value);
				}
			}

			static public (float, float) ScaleDPI
			{
				get
				{
					var scale = Raylib.GetWindowScaleDPI();
					return (scale.X, scale.Y);
				}
			}
		}

		// monitor stuff
		protected (int, int) MonitorDimensions
		{
			get
			{
				return (Raylib.GetMonitorWidth(Raylib.GetCurrentMonitor()), Raylib.GetMonitorHeight(Raylib.GetCurrentMonitor()));
			}
		}

		// scene-specific stuff
		public bool Enabled { get; private set; }
		#endregion
	}
}

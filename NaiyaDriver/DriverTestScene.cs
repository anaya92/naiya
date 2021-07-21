using System;
using Naiya;
using Raylib_cs;

namespace NaiyaDriver
{
	class DriverTestScene : NaiyaScene
	{
		protected override void OnEnable()
		{
			Window.Title = "DriverTestScene";
			Window.Dimensions = (640, 480);
			Window.MinimumDimensions = (640, 480);
			Window.State = ConfigFlags.FLAG_WINDOW_RESIZABLE;
		}

		public override void Draw()
		{
			Raylib.ClearBackground(Color.MAROON);
			Raylib.DrawText("a driver test scene for naiya engine :)", 10, 10, 25, Color.WHITE);
		}
	}
}

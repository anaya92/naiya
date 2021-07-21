using System;
using Naiya;

namespace NaiyaDriver
{
	class Program
	{
		static void Main(string[] args)
		{
			DriverTestScene testScene = new DriverTestScene();

			using (var game = new NaiyaGame())
			{
				game.AddScene(testScene);
				game.Run();
			}
		}
	}
}

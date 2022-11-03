using NUnit.Framework;
using WA.WinAPP.FourDicesGame;

namespace WA.WinApp.FourDicesGame.Tests
{
	public class GameTests
	{
		private void ShouldBeEqual(int n1, int n2, int n3, int n4, int expected)
		{
			var game = new Game(n1, n2, n3, n4);
			int actual = game.GetPoints();

			Assert.AreEqual(expected, actual);
		}

		[TestCase(1,2,3,1, 5)]
		public void GetPoints_2顆相同(int n1, int n2, int n3, int n4, int expected)
		{
			ShouldBeEqual(n1, n2, n3, n4, expected);
		}

		[TestCase(1, 3, 3, 3, 4)]
		public void GetPoints_3顆相同(int n1, int n2, int n3, int n4, int expected)
		{
			ShouldBeEqual(n1, n2, n3, n4, expected);
		}

		[TestCase(3, 3, 3, 3, 6)]
		public void GetPoints_4顆相同(int n1, int n2, int n3, int n4, int expected)
		{
			ShouldBeEqual(n1, n2, n3, n4, expected);
		}

		[TestCase(5, 3, 5, 3, 10)]
		public void GetPoints_2對(int n1, int n2, int n3, int n4, int expected)
		{
			ShouldBeEqual(n1, n2, n3, n4, expected);
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA.WinAPP.FourDicesGame
{
	public class Game
	{
		/// <summary>
		/// 4個骰子的點數, 已排序
		/// </summary>
		public int[] Dices { get; }

		private int pointOfPair; // 成對的最小點數

		/// <summary>
		/// 建構函數, 傳入 4個骰子的點數
		/// </summary>
		/// <param name="n1"></param>
		/// <param name="n2"></param>
		/// <param name="n3"></param>
		/// <param name="n4"></param>
		public Game(int n1, int n2, int n3, int n4)
		{
			var items = new int[] { n1,n2, n3, n4};
			Array.Sort(items); // 由小到大排序

			// 驗證是否至少有二顆相同, 並將成對的最小點數記錄在 pointOfPair
			if (items[0] == items[1])
			{
				pointOfPair = items[0];
			}else if (items[1] == items[2])
			{
				pointOfPair = items[1];
			}
			else if (items[2] == items[3])
			{
				pointOfPair = items[2];
			}
			else
			{
				throw new Exception("骰子點數沒有兩顆是相同的");
			}

			Dices = items;
		}

		public static Game NewGame()
		{
			var random = new Random(Guid.NewGuid().GetHashCode());
			int min = 1, max = 7;
			Game game = null;
			while (game == null)
			{
				try
				{
					game = new Game(random.Next(min, max),
						random.Next(min, max),
						random.Next(min, max),
						random.Next(min, max));
				}
				catch
				{
				}
			}

			return game;
		}

		/// <summary>
		/// 計算點數-扣除成對的最小點數兩顆,剩餘兩顆點數的總和
		/// </summary>
		/// <returns></returns>
		public int GetPoints()
		{
			// 計算四顆骰子點數總和
			int sum = this.Dices.Sum();

			// 扣除成對的最小點數的點數就是答案
			int result = sum - pointOfPair*2;

			//驗證, result值一定介於 2~12
			if (result < 2 || result > 12) throw new Exception("總點數計算有誤");

			return result;
		}

		public override string ToString()
		{
			return $"骰子: {Dices[0]}, {Dices[1]}, {Dices[2]}, {Dices[3]}. 總點數: {GetPoints()}";
		}
	}
}

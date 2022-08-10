using CodingSeb.ExpressionEvaluator;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Expression
{
	public class StringToMath
	{
		public static object Hesapla(string Cumle = "s1 + s2 <= 15 || s1 < s2")
		{
			ExpressionEvaluator evaluator = new();
			int s1 = 5;
			int s2 = 5;
			evaluator.Variables = new Dictionary<string, object>()
			{
				{ "s1", s1},
				{ "s2", s2},
			};

			return evaluator.Evaluate(Cumle);
		}
	}
}

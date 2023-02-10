using System;

namespace ThermophysicalParameterCalculator
{
	/// <summary>
	/// Для вычисления нам необходима следующая формула
	/// Tbf = A - B(53Cps + 40Cps^2)
	/// Для определения Cps, есть следующая формула
	/// Cps = Dsal / Dsal + 100W
	/// Если Itot <= 4 (W = Wtot)
	/// Если Itot > 4 (W = Wm)
	/// </summary>
	public class SoilCalculateResult : SoilData
	{
		public double W { get; private set; }
		public double A { get; private set; }
		public double B { get; private set; }
		public double Cps { get; }
		public double Tbf { get; private set; }

		public SoilCalculateResult(SoilTypes soilType, SoilSalinity soilSalinity, double dsal, double itot, double wtot, double wm) : base(soilType, soilSalinity, dsal, itot, wtot, wm)
		{
			CalculateItot();

			CalculateA();

			CalculateB();

			Cps = Dsal / (Dsal + 100 * W);

			CalculateTbf();
		}

		private void CalculateB()
		{
			switch (SoilSalinity)
			{
				case SoilSalinity.Unsalted: B = 0; break;
				case SoilSalinity.SalineMarineType: B = 1; break;
				case SoilSalinity.SalineContinentalType: B = 0.85; break;
			}
		}

		private void CalculateA()
		{
			switch (SoilType)
			{
				case SoilTypes.Clay: A = -0.25; break;
				case SoilTypes.Loam: A = -0.20; break;
				case SoilTypes.SandyLoamAndSiltySands: A = -0.15; break;
				case SoilTypes.SandsOfDifferentFractions: A = -0.10; break;
			}
		}

		private void CalculateItot()
		{
			if (Itot <= 0.4)
			{
				W = Wtot;
			}
			else
			{
				W = Wm;
			}
		}

		/// <summary>
		/// В таблице Б2 приводятся значения температуры
		/// начала замерзания Tbf для торфа
		/// Я прохожусь и смотрю если значение Wtot равно
		/// значению из таблицы, то я выставляю соответствующий ответ,
		/// иначе считаю по обычной формуле
		/// </summary>
		private void CalculateTbf()
		{
			if (SoilType == SoilTypes.PeatSlightlyDecomposed || SoilType == SoilTypes.PeatMediumDecomposed)
			{
				switch(Wtot)
				{
					case 7.30: Tbf = -0.14; break;
					case 5.90: Tbf = -0.16; break;
					case 3.27: Tbf = -0.25; break;
					case 1.64: Tbf = -0.35; break;
					case 3.50: Tbf = -0.13; break;
					case 0.90: Tbf = -0.20; break;
				}
			}
			else
			{
				Tbf = A - B * (53 * Cps + 40 * Math.Pow(Cps, 2));
			}
		}
	}
}

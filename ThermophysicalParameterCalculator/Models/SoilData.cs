namespace ThermophysicalParameterCalculator
{
	public class SoilData
	{
		/// <summary>
		/// SoilType - Тип грунта
		/// Soil Salinity - Засоленность грунта
		/// Dsal - Степень засоленности - Salinity
		/// Itot - Льдистость - Ice content
		/// Wtot - Суммарная влажность - Total Humidity
		/// Wm - Влажность мерзлого грунта - Frozen Ground Moisture
		/// </summary>

		public SoilTypes SoilType { get; }
		public SoilSalinity SoilSalinity { get; }
		public double Dsal { get; }
		public double Itot { get; }
		public double Wtot { get; }
		public double Wm { get; }		

		public SoilData(SoilTypes soilType, SoilSalinity soilSalinity, double dsal, double itot, double wtot, double wm)
		{
			SoilType = soilType;
			SoilSalinity = soilSalinity;
			Dsal = dsal;
			Itot = itot;
			Wtot = wtot;
			Wm = wm;
		}
	}
}

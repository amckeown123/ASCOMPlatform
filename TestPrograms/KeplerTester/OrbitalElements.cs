using ASCOM.Utilities;

using System;
using System.Text;

namespace KeplerConsoleApp
{
	internal class OrbitalElements
	{
		private const float BASE_EPOCH = 2400000.5f;

		public OrbitalElements( string def )
		{
			ParseElements( def );
		}

		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime PerihelionPassage { get; set; }
		public float Epoch { get; set; }
		public float PeriDistance { get; set; }
		public float OrbitalEccentricity { get; set; }
		public float ArgOfPerihelion { get; set; }
		public float LongitudeOfAscNode { get; set; }
		public float Inclination { get; set; }
		public float SlopeParameter { get; set; }
		public float VisualMagnitude { get; set; }

		private void ParseElements(string def ) 
		{
			string part;

			// Extract the Name and Description

			part = def.Substring( 102, 56 );
			int endName = part.IndexOf( "(" ) - 1;
			Name = part.Substring(0, endName).TrimEnd();
			string desc = part.Substring( endName + 1 );
			Description = desc.Replace( "(", "" ).Replace( ")", "" ).TrimEnd();

			// Extract date of perihelion passage

			part = def.Substring( 14, 4 );
			int ppYear = Int32.Parse( part );

			part = def.Substring( 19, 2 );
			int ppMonth = Int32.Parse( part );

			part = def.Substring( 22, 7 );
			float ppDay = float.Parse( part );

			DateTime dt = new DateTime( ppYear, ppMonth, 1);
			PerihelionPassage = dt.AddDays( ppDay -1 );

			Util util = new Util();
			Epoch = util.DateUTCToJulian( PerihelionPassage );

			// Extract Perihelion distance

			part = def.Substring( 30, 9 );
			PeriDistance = float.Parse( part );

			// Extract Orbital Eccentricity

			part = def.Substring( 41, 8 );
			OrbitalEccentricity = float.Parse( part );

			// Extract Argument of perihelion, J2000.0 degrees

			part = def.Substring( 51, 8 );
			ArgOfPerihelion = float.Parse( part );

			// Extract the longitude of the ascending node, J2000

			part = def.Substring( 61, 8 );
			LongitudeOfAscNode = float.Parse( part );

			// Extract the Inclination

			part = def.Substring( 71, 8 );
			Inclination = float.Parse( part );
}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine( $"Name = {Name}" );
			sb.AppendLine( $"Description = {Description}" );
			sb.AppendLine( $"Epoch = {Epoch:f5}" );
			sb.AppendLine( $"Perihelion Distance = {PeriDistance:f5}" );
			sb.AppendLine( $"Orbital Eccentricity = {OrbitalEccentricity:f5}" );
			sb.AppendLine( $"Inclination = {Inclination:f5}" );
			sb.AppendLine( $"Arg of Perihelion = {ArgOfPerihelion:f5}" );
			sb.Append( $"Longitude of Ascending Node = {LongitudeOfAscNode:f5}" );

			return sb.ToString();
		}
	}
}

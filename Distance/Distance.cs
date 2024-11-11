namespace Distance;

/// <summary>
/// Represents a distance, providing conversions between various units.
/// </summary>
public sealed class Distance : IComparable<Distance>, IEquatable<Distance>
{
    public const double Epsilon = 1e-4;

    public static readonly Distance Zero = new(0);


    #region SI Conversion Factors

    private const double KilometersPerMeter = 1.0 / 1000.0;
    private const double HectometersPerMeter = 1.0 / 100.0;
    private const double DecametersPerMeter = 1.0 / 10.0;
    private const double DecimetersPerMeter = 10.0;
    private const double CentimetersPerMeter = 100.0;
    private const double MillimetersPerMeter = 1000.0;

    #endregion


    #region Imperial Conversion Factors

    private const double LeaguesPerMeter = MilesPerMeter / 3;
    private const double MilesPerMeter = FeetPerMeter / 5280;
    private const double YardsPerMeter = 1.0936132983;
    private const double FeetPerMeter = 3.0 * YardsPerMeter;
    private const double InchesPerMeter = 12.0 * FeetPerMeter;

    #endregion


    #region Nautical Conversion Factors

    private const double NauticalMilesPerMeter = 1852;
    private const double FathomsPerMeter = 2 * YardsPerMeter;

    #endregion


    #region Public Properties

    public double Meters { get; }

    public double Kilometers => Meters * KilometersPerMeter;
    public double Hectometers => Meters * HectometersPerMeter;
    public double Decameters => Meters * DecametersPerMeter;
    public double Decimeters => Meters * DecimetersPerMeter;
    public double Centimeters => Meters * CentimetersPerMeter;
    public double Millimeters => Meters * MillimetersPerMeter;

    public double Leagues => Meters * LeaguesPerMeter;
    public double Miles => Meters * MilesPerMeter;
    public double Yards => Meters * YardsPerMeter;
    public double Feet => Meters * FeetPerMeter;
    public double Inches => Meters * InchesPerMeter;

    public double NauticalMiles => Meters * NauticalMilesPerMeter;
    public double Fathoms => Meters * FathomsPerMeter;

    #endregion


    /// <summary>
    /// Initializes a new instance of the <see cref="Distance"/> class with the specified value in meters.
    /// </summary>
    /// <param name="distance">The distance in meters.</param>
    private Distance(double distance)
    {
        Meters = distance;
    }


    #region SI Constructors

    /// <summary>
    /// Creates an <see cref="Distance"/> instance from a value in Meters.
    /// </summary>
    /// <param name="distance">The distance in meters.</param>
    public static Distance FromMeters(double distance) => new(distance);

    /// <summary>
    /// Creates an <see cref="Distance"/> instance from a value in Kilometers.
    /// </summary>
    /// <param name="distance">The distance in meters.</param>
    public static Distance FromKilometers(double distance) => new(distance / KilometersPerMeter);

    /// <summary>
    /// Creates an <see cref="Distance"/> instance from a value in Hectometers.
    /// </summary>
    /// <param name="distance">The distance in meters.</param>
    public static Distance FromHectometers(double distance) => new(distance / HectometersPerMeter);

    /// <summary>
    /// Creates an <see cref="Distance"/> instance from a value in Decameters.
    /// </summary>
    /// <param name="distance">The distance in meters.</param>
    public static Distance FromDecameters(double distance) => new(distance / DecametersPerMeter);

    /// <summary>
    /// Creates an <see cref="Distance"/> instance from a value in Decimeters.
    /// </summary>
    /// <param name="distance">The distance in meters.</param>
    public static Distance FromDecimeters(double distance) => new(distance / DecimetersPerMeter);

    /// <summary>
    /// Creates an <see cref="Distance"/> instance from a value in Centimeters.
    /// </summary>
    /// <param name="distance">The distance in meters.</param>
    public static Distance FromCentimeters(double distance) => new(distance / CentimetersPerMeter);

    /// <summary>
    /// Creates an <see cref="Distance"/> instance from a value in Millimeters.
    /// </summary>
    /// <param name="distance">The distance in meters.</param>
    public static Distance FromMillimeters(double distance) => new(distance / MillimetersPerMeter);

    #endregion


    #region Imperial Constructors

    /// <summary>
    /// Creates an <see cref="Distance"/> instance from a value in Leagues.
    /// </summary>
    /// <param name="distance">The distance in feet.</param>
    public static Distance FromLeagues(double distance) => new(distance / LeaguesPerMeter);

    /// <summary>
    /// Creates an <see cref="Distance"/> instance from a value in Miles.
    /// </summary>
    /// <param name="distance">The distance in feet.</param>
    public static Distance FromMiles(double distance) => new(distance / MilesPerMeter);

    /// <summary>
    /// Creates an <see cref="Distance"/> instance from a value in Yards.
    /// </summary>
    /// <param name="distance">The distance in feet.</param>
    public static Distance FromYards(double distance) => new(distance / YardsPerMeter);

    /// <summary>
    /// Creates an <see cref="Distance"/> instance from a value in Feet.
    /// </summary>
    /// <param name="distance">The distance in feet.</param>
    public static Distance FromFeet(double distance) => new(distance / FeetPerMeter);

    /// <summary>
    /// Creates an <see cref="Distance"/> instance from a value in Inches.
    /// </summary>
    /// <param name="distance">The distance in feet.</param>
    public static Distance FromInches(double distance) => new(distance / InchesPerMeter);

    #endregion


    #region Nautical Constructors

    /// <summary>
    /// Creates an <see cref="Distance"/> instance from a value in Nautical Miles.
    /// </summary>
    /// <param name="distance">The distance in nautical miles.</param>
    public static Distance FromNauticalMiles(double distance) => new(distance / NauticalMilesPerMeter);

    /// <summary>
    /// Creates an <see cref="Distance"/> instance from a value in Fathoms.
    /// </summary>
    /// <param name="distance">The distance in nautical miles.</param>
    public static Distance FromFathoms(double distance) => new(distance / FathomsPerMeter);

    #endregion


    #region Comparators

    public static bool operator >(Distance a, Distance b) => a.CompareTo(b) > 0;
    public static bool operator <(Distance a, Distance b) => a.CompareTo(b) < 0;
    public static bool operator >=(Distance a, Distance b) => a.CompareTo(b) > 0 || a.Equals(b);
    public static bool operator <=(Distance a, Distance b) => a.CompareTo(b) < 0 || a.Equals(b);
    public static bool operator ==(Distance a, Distance b) => a.Equals(b);
    public static bool operator !=(Distance a, Distance b) => !a.Equals(b);

    #endregion


    #region Operators

    public static Distance operator +(Distance a1, Distance a2) => new(a1.Meters + a2.Meters);
    public static Distance operator -(Distance a1, Distance a2) => new(a1.Meters - a2.Meters);
    public static Distance operator *(Distance distance, double scalar) => new(distance.Meters * scalar);
    public static Distance operator /(Distance distance, double scalar) => new(distance.Meters / scalar);

    #endregion


    #region IComparable<Distance>

    public int CompareTo(Distance? other) => other is null ? 1 : Meters.CompareTo(other.Meters);

    #endregion


    #region IEquatable<Distance>

    public bool Equals(Distance? other) => other is not null && Math.Abs(Meters - other.Meters) < Epsilon;
    public override bool Equals(object? obj) => obj is Distance other && Equals(other);
    public override int GetHashCode() => Meters.GetHashCode();

    #endregion


    public override string ToString() => $"{Meters:G} Meters";
}
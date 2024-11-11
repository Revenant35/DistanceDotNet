namespace DistanceTests;

using Distance;
using Bogus;

[TestClass]
public class DistanceTests
{
    private readonly Faker _faker = new();

    [TestMethod]
    public void FromMeters_ReturnsCorrectDistance()
    {
        var expected = _faker.Random.Double();

        // Act
        var distance = Distance.FromMeters(expected);

        // Assert
        Assert.AreEqual(expected, distance.Meters, Distance.Epsilon);
    }

    [TestMethod]
    public void FromKilometers_ReturnsCorrectDistance()
    {
        var expected = _faker.Random.Double();

        // Act
        var distance = Distance.FromKilometers(expected);

        // Assert
        Assert.AreEqual(expected, distance.Kilometers, Distance.Epsilon);
    }

    [TestMethod]
    public void FromHectometers_ReturnsCorrectDistance()
    {
        var expected = _faker.Random.Double();

        // Act
        var distance = Distance.FromHectometers(expected);

        // Assert
        Assert.AreEqual(expected, distance.Hectometers, Distance.Epsilon);
    }

    [TestMethod]
    public void FromDecameters_ReturnsCorrectDistance()
    {
        var expected = _faker.Random.Double();

        // Act
        var distance = Distance.FromDecameters(expected);

        // Assert
        Assert.AreEqual(expected, distance.Decameters, Distance.Epsilon);
    }

    [TestMethod]
    public void FromDecimeters_ReturnsCorrectDistance()
    {
        var expected = _faker.Random.Double();

        // Act
        var distance = Distance.FromDecimeters(expected);

        // Assert
        Assert.AreEqual(expected, distance.Decimeters, Distance.Epsilon);
    }

    [TestMethod]
    public void FromCentimeters_ReturnsCorrectDistance()
    {
        var expected = _faker.Random.Double();

        // Act
        var distance = Distance.FromCentimeters(expected);

        // Assert
        Assert.AreEqual(expected, distance.Centimeters, Distance.Epsilon);
    }

    [TestMethod]
    public void FromMillimeters_ReturnsCorrectDistance()
    {
        var expected = _faker.Random.Double();

        // Act
        var distance = Distance.FromMillimeters(expected);

        // Assert
        Assert.AreEqual(expected, distance.Millimeters, Distance.Epsilon);
    }

    [TestMethod]
    public void FromLeagues_ReturnsCorrectDistance()
    {
        var expected = _faker.Random.Double();

        // Act
        var distance = Distance.FromLeagues(expected);

        // Assert
        Assert.AreEqual(expected, distance.Leagues, Distance.Epsilon);
    }

    [TestMethod]
    public void FromMiles_ReturnsCorrectDistance()
    {
        var expected = _faker.Random.Double();

        // Act
        var distance = Distance.FromMiles(expected);

        // Assert
        Assert.AreEqual(expected, distance.Miles, Distance.Epsilon);
    }

    [TestMethod]
    public void FromYards_ReturnsCorrectDistance()
    {
        var expected = _faker.Random.Double();

        // Act
        var distance = Distance.FromYards(expected);

        // Assert
        Assert.AreEqual(expected, distance.Yards, Distance.Epsilon);
    }

    [TestMethod]
    public void FromFeet_ReturnsCorrectDistance()
    {
        var expected = _faker.Random.Double();

        // Act
        var distance = Distance.FromFeet(expected);

        // Assert
        Assert.AreEqual(expected, distance.Feet, Distance.Epsilon);
    }

    [TestMethod]
    public void FromInches_ReturnsCorrectDistance()
    {
        var expected = _faker.Random.Double();

        // Act
        var distance = Distance.FromInches(expected);

        // Assert
        Assert.AreEqual(expected, distance.Inches, Distance.Epsilon);
    }

    [TestMethod]
    public void FromNauticalMiles_ReturnsCorrectDistance()
    {
        var expected = _faker.Random.Double();

        // Act
        var distance = Distance.FromNauticalMiles(expected);

        // Assert
        Assert.AreEqual(expected, distance.NauticalMiles, Distance.Epsilon);
    }
    
    [TestMethod]
    public void FromFathoms_ReturnsCorrectDistance()
    {
        var expected = _faker.Random.Double();

        // Act
        var distance = Distance.FromFathoms(expected);

        // Assert
        Assert.AreEqual(expected, distance.Fathoms, Distance.Epsilon);
    }
    
    // Arithmetic operations
    [TestMethod]
    public void Addition_ShouldReturnCorrectSum()
    {
        // Arrange
        var distance1 = Distance.FromMeters(1000);
        var distance2 = Distance.FromMeters(500);

        // Act
        var result = distance1 + distance2;

        // Assert
        Assert.AreEqual(1500, result.Meters, Distance.Epsilon);
    }

    [TestMethod]
    public void Subtraction_ShouldReturnCorrectDifference()
    {
        // Arrange
        var distance1 = Distance.FromMeters(1000);
        var distance2 = Distance.FromMeters(500);

        // Act
        var result = distance1 - distance2;

        // Assert
        Assert.AreEqual(500, result.Meters, Distance.Epsilon);
    }

    [TestMethod]
    public void Multiplication_ShouldReturnCorrectProduct()
    {
        // Arrange
        var distance = Distance.FromMeters(1000);

        // Act
        var result = distance * 2;

        // Assert
        Assert.AreEqual(2000, result.Meters, Distance.Epsilon);
    }

    [TestMethod]
    public void Division_ShouldReturnCorrectQuotient()
    {
        // Arrange
        var distance = Distance.FromMeters(1000);

        // Act
        var result = distance / 2;

        // Assert
        Assert.AreEqual(500, result.Meters, Distance.Epsilon);
    }


    // Comparison operators
    [TestMethod]
    public void GreaterThan_ShouldReturnTrueWhenFirstDistanceIsLarger()
    {
        // Arrange
        var distance1 = Distance.FromMeters(90);
        var distance2 = Distance.FromMeters(45);

        // Assert
        Assert.IsTrue(distance1 > distance2);
    }

    [TestMethod]
    public void LessThan_ShouldReturnTrueWhenFirstDistanceIsSmaller()
    {
        // Arrange
        var distance1 = Distance.FromMeters(30);
        var distance2 = Distance.FromMeters(45);

        // Assert
        Assert.IsTrue(distance1 < distance2);
    }

    [TestMethod]
    public void GreaterThanOrEqual_ShouldReturnTrueWhenDistancesAreEqualOrLarger()
    {
        // Arrange
        var distance1 = Distance.FromMeters(90);
        var distance2 = Distance.FromMeters(90);

        // Assert
        Assert.IsTrue(distance1 >= distance2);
    }

    [TestMethod]
    public void LessThanOrEqual_ShouldReturnTrueWhenDistancesAreEqualOrSmaller()
    {
        // Arrange
        var distance1 = Distance.FromMeters(30);
        var distance2 = Distance.FromMeters(45);

        // Assert
        Assert.IsTrue(distance1 <= distance2);
    }

    // Equality
    [TestMethod]
    public void Equality_ShouldReturnTrueForEqualDistances()
    {
        // Assert
        Assert.AreEqual(Distance.FromMeters(90), Distance.FromMeters(90));
        Assert.AreNotEqual(Distance.FromMeters(90), Distance.FromMeters(91));
    }

    [TestMethod]
    public void Inequality_ShouldReturnTrueForDifferentDistances()
    {
        // Arrange
        var distance1 = Distance.FromMeters(90);
        var distance2 = Distance.FromMeters(45);

        // Assert
        Assert.IsTrue(distance1 != distance2);
    }


    [TestMethod]
    public void GetHashCode_ShouldReturnSameForTwoDistances_WhenMetersAreEqual()
    {
        // Arrange
        var distance1 = Distance.FromMeters(45);
        var distance2 = Distance.FromMeters(45);

        // Assert
        Assert.AreEqual(distance1.GetHashCode(), distance2.GetHashCode());
    }

    [TestMethod]
    public void GetHashCode_ShouldReturnDifferentForTwoDistances_WhenMetersAreNotEqual()
    {
        // Arrange
        var distance1 = Distance.FromMeters(90);
        var distance2 = Distance.FromMeters(45);

        // Assert
        Assert.AreNotEqual(distance1.GetHashCode(), distance2.GetHashCode());
    }
}
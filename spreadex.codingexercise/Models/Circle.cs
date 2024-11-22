using spreadex.codingexercise.Models.Abstractions;
namespace spreadex.codingexercise.Models;

/// <summary>
/// The circle widget.
/// </summary>
public class Circle : Widget
{
    /// <summary>
    /// Gets the diameter of the circle.
    /// </summary>
    public int Diameter { get; }
    
    /// <summary>
    /// Initializes a new instance of the <see cref="Circle"/> class.
    /// </summary>
    /// <param name="x">The x-coordinate of the circle.</param>
    /// <param name="y">The y-coordinate of the circle.</param>
    /// <param name="diameter">The diameter of the circle.</param>
    /// <exception cref="ArgumentException">Thrown when diameter is less than or equal to zero.</exception>
    public Circle(int x, int y, int diameter) : base(x, y)
    {
        if (diameter <= 0)
            throw new ArgumentException("Diameter must be greater than 0.");
        Diameter = diameter;
    }

    /// <summary>
    /// Retrieves the details of the circle.
    /// </summary>
    /// <returns>A string containing the details of the circle.</returns>
    public override string GetDetails()
    {
        return $"Circle ({X},{Y}) size={Diameter}";
    }
}

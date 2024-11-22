using spreadex.codingexercise.Models.Abstractions;

namespace spreadex.codingexercise.Models;

/// <summary>
/// The ellipse widget.
/// </summary>
public class Ellipse : Widget
{
    /// <summary>
    /// Gets the x-coordinate of the ellipse.
    /// </summary>
    public int X { get; }
    
    /// <summary>
    /// Gets the y-coordinate of the ellipse.
    /// </summary>
    public int Y { get; }
    
    /// <summary>
    /// Gets the horizontal diameter of the ellipse.
    /// </summary>
    public int HorizontalDiameter { get; }
    
    /// <summary>
    /// Gets the vertical diameter of the ellipse.
    /// </summary>
    public int VerticalDiameter { get; }
    
    /// <summary>
    /// Initializes a new instance of the <see cref="Ellipse"/> class.
    /// </summary>
    /// <param name="x">The x-coordinate of the ellipse.</param>
    /// <param name="y">The y-coordinate of the ellipse.</param>
    /// <param name="horizontalDiameter">The horizontal diameter of the ellipse.</param>
    /// <param name="verticalDiameter">The vertical diameter of the ellipse.</param>
    /// <exception cref="ArgumentException">Thrown when horizontal or vertical diameter is less than or equal to zero.</exception>
    public Ellipse(int x, int y, int horizontalDiameter, int verticalDiameter) : base(x, y)
    {
        if (horizontalDiameter <= 0 || verticalDiameter <= 0)
            throw new ArgumentException("Diameters must be greater than 0.");
        
        X = x;
        Y = y;
        HorizontalDiameter = horizontalDiameter;
        VerticalDiameter = verticalDiameter;
    }
    
    /// <summary>
    /// Retrieves the details of the ellipse.
    /// </summary>
    /// <returns>A string containing the details of the ellipse.</returns>
    public override string GetDetails()
    {
        return $"Ellipse ({X},{Y}) diameterH={HorizontalDiameter} diameterV={VerticalDiameter}";
    }
}
using spreadex.codingexercise.Models.Abstractions;
namespace spreadex.codingexercise.Models;

/// <summary>
/// The rectangle widget.
/// </summary>
public class Rectangle : Widget
{
    /// <summary>
    /// Gets the width of the rectangle.
    /// </summary>
    public int Width { get; }
    
    /// <summary>
    /// Gets the height of the rectangle.
    /// </summary>
    public int Height { get; }
    
    /// <summary>
    /// Initializes a new instance of the <see cref="Rectangle"/> class.
    /// </summary>
    /// <param name="x">The x-coordinate of the rectangle.</param>
    /// <param name="y">The y-coordinate of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <exception cref="ArgumentException">Thrown when width or height is less than or equal to zero.</exception>
    public Rectangle(int x, int y, int width, int height) : base(x, y)
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Width and Height must be greater than 0.");
        Width = width;
        Height = height;
    }
    
    /// <summary>
    /// Retrieves the details of the rectangle.
    /// </summary>
    /// <returns>A string containing the details of the rectangle.</returns>
    public override string GetDetails()
    {
        return $"Rectangle ({X},{Y} ) width={Width} height={Height}";
    }
}

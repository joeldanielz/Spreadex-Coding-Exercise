using spreadex.codingexercise.Models.Abstractions;

namespace spreadex.codingexercise.Models;

/// <summary>
/// The square widget.
/// </summary>
public class Square : Widget
{
    /// <summary>
    /// Gets the x-coordinate of the square.
    /// </summary>
    public int X { get; }
    
    /// <summary>
    /// Gets the y-coordinate of the square.
    /// </summary>
    public int Y { get; }
    
    /// <summary>
    /// Gets the size of the square.
    /// </summary>
    public int Size { get; }
    
    /// <summary>
    /// Initializes a new instance of the <see cref="Square"/> class.
    /// </summary>
    /// <param name="x">The x-coordinate of the square.</param>
    /// <param name="y">The y-coordinate of the square.</param>
    /// <param name="size">The size of the square.</param>
    /// <exception cref="ArgumentException">Thrown when size is less than or equal to zero.</exception>
    public Square(int x, int y, int size) : base(x, y)
    {
        if (size <= 0)
            throw new ArgumentException("Size must be greater than 0.");
        X = x;
        Y = y;
        Size = size;
    }
    
    /// <summary>
    /// Retrieves the details of the square.
    /// </summary>
    /// <returns>A string containing the details of the square.</returns>
    public override string GetDetails()
    {
        return $"Square ({X},{Y}) size={Size}";
    }
}
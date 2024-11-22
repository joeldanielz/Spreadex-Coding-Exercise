using spreadex.codingexercise.Models.Abstractions;

namespace spreadex.codingexercise.Models;

/// <summary>
/// The textbox widget.
/// </summary>
public class Textbox : Widget
{
    /// <summary>
    /// Gets the x-coordinate of the textbox.
    /// </summary>
    public int X { get; }
    
    /// <summary>
    /// Gets the y-coordinate of the textbox.
    /// </summary>
    public int Y { get; }
    
    /// <summary>
    /// Gets the width of the textbox.
    /// </summary>
    public int Width { get; }
    
    /// <summary>
    /// Gets the height of the textbox.
    /// </summary>
    public int Height { get; }
    
    /// <summary>
    /// Gets the text content of the textbox.
    /// </summary>
    public string Text { get; }
    
    /// <summary>
    /// Initializes a new instance of the <see cref="Textbox"/> class.
    /// </summary>
    /// <param name="x">The x-coordinate of the textbox.</param>
    /// <param name="y">The y-coordinate of the textbox.</param>
    /// <param name="width">The width of the textbox.</param>
    /// <param name="height">The height of the textbox.</param>
    /// <param name="text">The text content of the textbox.</param>
    /// <exception cref="ArgumentException">Thrown when width or height is less than or equal to zero.</exception>
    public Textbox(int x, int y, int width, int height, string text) : base(x, y)
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Width and Height must be greater than 0.");
        X = x;
        Y = y;
        Width = width;
        Height = height;
        Text = text;
    }
    
    /// <summary>
    /// Retrieves the details of the textbox.
    /// </summary>
    /// <returns>A string containing the details of the textbox.</returns>
    public override string GetDetails()
    {
        return $"Textbox ({X},{Y}) width={Width} height={Height} Text=\"{Text}\"";
    }
}

namespace spreadex.codingexercise.Models.Abstractions;

/// <summary>
/// The abstract widget class
/// </summary>
public abstract class Widget
{
    /// <summary>
    /// Gets or sets the X Coordinates.
    /// </summary>
    public int X { get; set; }

    /// <summary>
    /// Gets or sets the Y Coordinates.
    /// </summary>
    public int Y { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    protected Widget(int x, int y)
    {
        X = x;
        Y = y;
    }
    
    /// <summary>
    /// Retrieves the details of the widget.
    /// </summary>
    /// <returns>A string containing the details of the widget.</returns>
    public abstract string GetDetails();
}
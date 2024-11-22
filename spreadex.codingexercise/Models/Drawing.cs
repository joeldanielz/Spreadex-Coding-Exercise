using spreadex.codingexercise.Models.Abstractions;
namespace spreadex.codingexercise;

/// <summary>
/// Represents a collection of widgets that can be managed and printed.
/// </summary>
public class Drawing
{
    /// <summary>
    /// Gets or sets a list of widgets.
    /// </summary>
    private readonly List<Widget> _widgets = new List<Widget>();

    /// <summary>
    /// Adds a widget to the drawing.
    /// </summary>
    /// <param name="widget">The widget to add.</param>
    public void AddWidget(Widget widget)
    {
        _widgets.Add(widget);
    }
    
    /// <summary>
    /// Prints the details of all widgets in the drawing.
    /// </summary>
    public void WriteToConsole()
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("Requested Drawing");
        Console.WriteLine("----------------------------------------------------------------");
        _widgets.ForEach(widget => Console.WriteLine(widget.GetDetails()));
        Console.WriteLine("----------------------------------------------------------------");
    }


    // Read-only prop for testing purposes
    public IReadOnlyList<Widget> Widgets => _widgets.AsReadOnly();
}
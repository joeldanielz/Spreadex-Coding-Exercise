namespace spreadex.codingexercise.Models
{
    /// <summary>
    /// The Program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main method for the console application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var drawing = new Drawing();

            // Add widgets to the drawing object.
            drawing.AddWidget(new Rectangle(10, 10, 30, 40));
            drawing.AddWidget(new Square(15, 30, 35));
            drawing.AddWidget(new Ellipse(100, 150, 300, 200));
            drawing.AddWidget(new Circle(1, 1, 300));
            drawing.AddWidget(new Textbox(5, 5, 200, 100, "sample text"));
            
            // Print all widget details within the drawing object.
            drawing.WriteToConsole();
        }
    }
}

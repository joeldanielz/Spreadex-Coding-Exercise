using spreadex.codingexercise;
using spreadex.codingexercise.Models;
using spreadex.codingexercise.Tests.Mock;

namespace spreadex.codingexercise.Tests
{
    public class DrawingTests
    {
        /// <summary>
        /// Makes sure that the widgets have been inserted into the list.
        /// </summary>
        [Fact]
        public void AddWidget_ShouldAddWidgetToList()
        {
            // Arrange
            var drawing = new Drawing();
            var widget = new MockWidget(10, 20);
            // Act
            drawing.AddWidget(widget);
            // Assert
            Assert.Contains(widget, drawing.Widgets);
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void Print_ShouldPrintAllWidgetDetails()
        {
            // Arrange
            var drawing = new Drawing();
            var testWidget1 = new MockWidget(10, 20);
            var testWidget2 = new MockWidget(30, 40);
            drawing.AddWidget(testWidget1);
            drawing.AddWidget(testWidget2);
            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                drawing.WriteToConsole();
                var result = sw.ToString().Trim();
                // Assert
                Assert.Contains(testWidget1.GetDetails(), result);
                Assert.Contains(testWidget2.GetDetails(), result);
            }
        }
    }
}

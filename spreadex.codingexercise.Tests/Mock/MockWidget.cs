using spreadex.codingexercise.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spreadex.codingexercise.Tests.Mock
{
    /// <summary>
    /// The Mock Widget.
    /// </summary>
    public class MockWidget : Widget
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MockWidget"/> class.
        /// </summary>
        /// <param name="x">The x-coordinate of the widget.</param>
        /// <param name="y">The y-coordinate of the widget.</param>
        public MockWidget(int x, int y) : base(x, y) { }
        
        /// <summary>
        /// Retrieves the details of the mock widget.
        /// </summary>
        /// <returns>A string containing the details of the mock widget.</returns>
        public override string GetDetails()
        {
            return $"MockWidget at ({X}, {Y})";
        }
    }
}

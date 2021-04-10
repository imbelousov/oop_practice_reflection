using Blazor.Extensions.Canvas.Canvas2D;

namespace Paint.Models
{
    public class DrawingContext
    {
        public Point StartPosition { get; set; }
        public Point PreviousPosition { get; set; }
        public Point CurrentPosition { get; set; }
        public Canvas2DContext Preview { get; set; }
        public Canvas2DContext Image { get; set; }
        public string Color { get; set; }
    }
}

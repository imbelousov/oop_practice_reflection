using System.Threading.Tasks;
using Blazor.Extensions.Canvas.Canvas2D;
using Paint.Models;

namespace Paint.Tools
{
    public class LineTool : ITool
    {
        public char Icon => '\u2571';

        public string Name => "Line";

        public Task StartDraw(DrawingContext context) => Task.CompletedTask;

        public Task Draw(DrawingContext context) =>
            Draw(context.Preview, context.StartPosition, context.CurrentPosition, context.Color);

        public Task FinishDraw(DrawingContext context) =>
            Draw(context.Image, context.StartPosition, context.CurrentPosition, context.Color);

        private async Task Draw(Canvas2DContext canvas, Point from, Point to, string color)
        {
            await canvas.SetLineWidthAsync(1);
            await canvas.SetStrokeStyleAsync(color);
            await canvas.BeginPathAsync();
            await canvas.MoveToAsync(from.X, from.Y);
            await canvas.LineToAsync(to.X, to.Y);
            await canvas.StrokeAsync();
        }
    }
}

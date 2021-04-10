using System;
using System.Threading.Tasks;
using Blazor.Extensions.Canvas.Canvas2D;
using Paint.Models;

namespace Paint.Tools
{
    public class PencilTool : ITool
    {
        public char Icon => '\u2710';

        public string Name => "Pencil";

        public async Task StartDraw(DrawingContext context)
        {
            await context.Image.SetLineWidthAsync(1);
            await context.Image.SetStrokeStyleAsync(context.Color);
            await context.Image.BeginPathAsync();
            await context.Image.ArcAsync(context.CurrentPosition.X, context.CurrentPosition.Y, 0.5, 0, Math.PI * 2);
            await context.Image.StrokeAsync();
        }

        public Task Draw(DrawingContext context) =>
            Draw(context.Image, context.PreviousPosition, context.CurrentPosition, context.Color);

        public Task FinishDraw(DrawingContext context) =>
            Draw(context.Image, context.PreviousPosition, context.CurrentPosition, context.Color);

        private async Task Draw(Canvas2DContext canvas, Point previous, Point current, string color)
        {
            await canvas.SetLineWidthAsync(1);
            await canvas.SetStrokeStyleAsync(color);
            await canvas.BeginPathAsync();
            await canvas.MoveToAsync(previous.X, previous.Y);
            await canvas.LineToAsync(current.X, current.Y);
            await canvas.StrokeAsync();
        }
    }
}

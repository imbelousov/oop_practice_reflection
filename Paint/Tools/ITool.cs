using System.Threading.Tasks;
using Paint.Models;

namespace Paint.Tools
{
    public interface ITool
    {
        char Icon { get; }
        string Name { get; }
        Task StartDraw(DrawingContext context);
        Task Draw(DrawingContext context);
        Task FinishDraw(DrawingContext context);
    }
}

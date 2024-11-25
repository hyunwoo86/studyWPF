using System.Collections.Generic;
using System.Windows.Media;

namespace studyWPF.Models
{
    class ComboItem
    {
        public string Value { set; get; } = default;
        public Brush Brush { set; get; } = default;

        public override string ToString()
        {
            return $"Value: {Value}, Brush: {Brush}";
        }

        public static List<ComboItem> Items = new List<ComboItem>()
        {
            new ComboItem{Value="빨간색", Brush = Brushes.Red},
            new ComboItem{Value="파란색", Brush = Brushes.Blue},
            new ComboItem{Value="초록색", Brush = Brushes.Green},

        };
    }
}

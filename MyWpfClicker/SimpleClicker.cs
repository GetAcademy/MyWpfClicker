using System.Windows;
using System.Windows.Controls;

namespace MyWpfClicker
{
    internal class SimpleClicker
    {
        private readonly Label _label;
        private int _count;
        public StackPanel Panel { get; }

        public SimpleClicker()
        {
            Panel = new StackPanel
            {
                Orientation = Orientation.Horizontal
            };
            var button = new Button
            {
                Content = "Trykk her!"
            };
            button.Click += ButtonClick;
            _label = new Label
            {
                Content = "Trykk på knappen!"
            };
            Panel.Children.Add(button);
            Panel.Children.Add(_label);

        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}

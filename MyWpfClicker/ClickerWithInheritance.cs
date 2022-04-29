using System.Windows;
using System.Windows.Controls;

namespace MyWpfClicker
{
    internal class ClickerWithInheritance
        : StackPanel
    {
        private readonly Label _label;
        private int _count;

        public ClickerWithInheritance() : base()
        {
            Orientation = Orientation.Horizontal;
            var button = new Button
            {
                Content = "Trykk her!"
            };
            button.Click += ButtonClick;
            _label = new Label
            {
                Content = "Trykk på knappen!"
            };
            Children.Add(button);
            Children.Add(_label);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}

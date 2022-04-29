using System;
using System.Windows;
using System.Windows.Controls;

namespace MyWpfClicker
{
    internal class Program
    {

        // Versjon 3
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();
            var clicker1 = new ClickerWithInheritance();
            var clicker2 = new ClickerWithInheritance();
            var clicker3 = new ClickerWithInheritance();

            var panel = new StackPanel();
            panel.Children.Add(clicker1);
            panel.Children.Add(clicker2);
            panel.Children.Add(clicker3);
            window.Content = panel;
            app.Run(window);
        }

        /* Versjon 2 med klasse
        private static int _count;
        private static Label _label;
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();
            var clicker1 = new SimpleClicker();
            var clicker2 = new SimpleClicker();
            var clicker3 = new SimpleClicker();

            var panel = new StackPanel();
            panel.Children.Add(clicker1.Panel);
            panel.Children.Add(clicker2.Panel);
            panel.Children.Add(clicker3.Panel);
            window.Content = panel;
            app.Run(window);
        }         
         */

        /*
         Versjon 1: 
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();
            var panel = new StackPanel
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
            panel.Children.Add(button);
            panel.Children.Add(_label);
            window.Content = panel;
            app.Run(window);
        }         

        private static void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
        */
    }
}

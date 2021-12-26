using System;
using System.IO;
using System.Windows;
using System.Windows.Media;

namespace Swagger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static DragDropEffects _dragDropEffects = DragDropEffects.None;

        public MainWindow()
        {
            InitializeComponent();
            File.WriteAllText(@"C:\Users\someone\Desktop\test.txt", "");
        }

        private void Grid_DragEnter(object sender, DragEventArgs e)
        {
            Grid.Background = Brushes.LightGreen;
            _dragDropEffects = DragDropEffects.Copy;
            File.AppendAllText(@"C:\Users\someone\Desktop\test.txt", "Grid_DragEnter\r\n");
        }

        private void Grid_DragOver(object sender, DragEventArgs e)
        {
            e.Effects = _dragDropEffects;
            e.Handled = true;
        }

        private void Grid_DragLeave(object sender, EventArgs e)
        {
            Grid.Background = Brushes.Beige;
            File.AppendAllText(@"C:\Users\someone\Desktop\test.txt", "Grid_DragLeave\r\n");
        }

        private void Text_DragEnter(object sender, DragEventArgs e)
        {
            Text.Background = Brushes.LightGreen;
            _dragDropEffects = DragDropEffects.Copy;
            File.AppendAllText(@"C:\Users\someone\Desktop\test.txt", "Text_DragEnter\r\n");
        }

        private void Text_DragOver(object sender, DragEventArgs e)
        {
            e.Effects = _dragDropEffects;
            e.Handled = true;
        }

        private void Text_DragLeave(object sender, EventArgs e)
        {
            Text.Background = Brushes.White;
            File.AppendAllText(@"C:\Users\someone\Desktop\test.txt", "Text_DragLeave\r\n");
        }
    }
}

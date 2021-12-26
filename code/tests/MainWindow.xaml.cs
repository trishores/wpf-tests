using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FrameworkPropertyMetadata fpm1 = (FrameworkPropertyMetadata)AllowDropProperty.GetMetadata(typeof(Canvas));
            Debug.WriteLine($"canvas1.AllowDropProperty inherits is {fpm1.Inherits}");
            canvas1.AllowDrop = true;
            Debug.WriteLine($"canvas1.AllowDrop set to {canvas1.AllowDrop}");
            Debug.WriteLine($"panel1.AllowDrop: {panel1.AllowDrop}");
            Debug.WriteLine($"label1.AllowDrop: {label1.AllowDrop}");

            FrameworkPropertyMetadata fpm2 = (FrameworkPropertyMetadata)AllowDropProperty.GetMetadata(typeof(Canvas2));
            Debug.WriteLine($"canvas2.AllowDropProperty inherits is {fpm2.Inherits}");
            canvas2.AllowDrop = true;
            Debug.WriteLine($"canvas2.AllowDrop set to {canvas2.AllowDrop}");
            Debug.WriteLine($"panel2.AllowDrop: {panel2.AllowDrop}");
            Debug.WriteLine($"label2.AllowDrop: {label2.AllowDrop}");

            /*
            canvas1.AllowDropProperty inherits is True
            canvas1.AllowDrop set to True
            panel1.AllowDrop: True
            label1.AllowDrop: True

            canvas2.AllowDropProperty inherits is False
            canvas2.AllowDrop set to True
            panel2.AllowDrop: False
            label2.AllowDrop: False
            */
        }
    }

    public class Canvas2 : Canvas
    {
        static Canvas2()
        {
            FrameworkPropertyMetadata fpm = new();
            fpm.Inherits = false;

            AllowDropProperty.OverrideMetadata(typeof(Canvas2), fpm);
        }
    }
}

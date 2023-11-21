﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZImageTests.GUI.Controls.Elementary
{
    /// <summary>
    /// Interaction logic for ZoomPicker.xaml
    /// </summary>
    public partial class ZoomPicker : UserControl
    {
        public ZoomPicker()
        {
            InitializeComponent();
        }



        public double Zoom
        {
            get { return (double)GetValue(ZoomProperty); }
            set { SetValue(ZoomProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Zoom.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ZoomProperty =
            DependencyProperty.Register("Zoom", typeof(double), typeof(ZoomPicker), new PropertyMetadata(100));








        public List<double> ZoomList
        {
            get { return (List<double>)GetValue(ZoomListProperty); }
            set { SetValue(ZoomListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ZoomList.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ZoomListProperty =
            DependencyProperty.Register("ZoomList", typeof(List<double>), typeof(ZoomPicker), new PropertyMetadata(ZoomListDoubles));

        public static List<double> ZoomListDoubles = new List<double>() { 20, 50, 70, 100, 150, 200, 400 };




    }
}

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
using ZImageTests.Process.Parameters;

namespace ZImageTests.Controls.ProcessControls.ControlSliders
{
    /// <summary>
    /// Interaction logic for ContinuousSlider.xaml
    /// </summary>
    public partial class ContinuousSlider : UserControl
    {
        public ContinuousSlider(DoubleParam doubleParam)
        {
            InitializeComponent();
        }

        public ContinuousSlider(IntParam intParam)
        {
            InitializeComponent();
        }
    }
}

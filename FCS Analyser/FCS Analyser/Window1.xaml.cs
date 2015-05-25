using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FCS_Analyser
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            this.lbFCSContent.Items.Add("Item1");
            this.lbFCSContent.Items.Add("Item2");
            this.lbFCSContent.Items.Add("Item3");
            this.lbFCSContent.Items.Add("Item4");
           
        }


    }
}

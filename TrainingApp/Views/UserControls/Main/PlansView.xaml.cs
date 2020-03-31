using Prism.Regions;
using System;
using System.Collections.Generic;
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

namespace TrainingApp.Views.UserControls.Main
{
  /// <summary>
  /// Interaction logic for PlansView.xaml
  /// </summary>
  public partial class PlansView : UserControl
  {
    public PlansView(IRegionManager regionManager)
    {
      InitializeComponent();
    }
  }
}

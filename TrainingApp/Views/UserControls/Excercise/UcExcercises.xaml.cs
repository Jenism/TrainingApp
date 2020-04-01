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
using TrainingApp.ViewModels.Main;

namespace TrainingApp.Views.UserControls.Excercise
{
  /// <summary>
  /// Interaction logic for ExcercisesView.xaml
  /// </summary>
  public partial class UcExcercises : UserControl
  {
    public UcExcercises(ExcercisesVM excercisesVM)
    {
      DataContext = excercisesVM;
      InitializeComponent();
    }
  }
}

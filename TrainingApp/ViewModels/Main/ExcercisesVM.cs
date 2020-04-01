using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TrainingApp.ViewModels.Main
{
  public class ExcercisesVM : BindableBase
  {
    private ObservableCollection<ExcerciseVM> excercises = new ObservableCollection<ExcerciseVM>
    {
      new ExcerciseVM {Name = "Bench press", Description = "BenchPress is amazing"},
      new ExcerciseVM {Name = "Squat", Description = "Squats are easy"},
      new ExcerciseVM {Name = "Plank", Description = "Excercise for core strength"},
    };
    public ObservableCollection<ExcerciseVM> Excercises
    {
      get { return excercises; }
      set
      {
        if (excercises != value)
        {
          excercises = value;
          RaisePropertyChanged();
        }
      }
    }

    private ExcerciseVM selectedExcercise = null;
    public ExcerciseVM SelectedExcercise
    {
      get { return selectedExcercise; }
      set
      {
        if (selectedExcercise != value)
        {
          selectedExcercise = value;
          RaisePropertyChanged();
        }
      }
    }
  }
}

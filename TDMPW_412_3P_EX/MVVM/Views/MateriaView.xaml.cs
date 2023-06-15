using System.Diagnostics;
using TDMPW_412_3P_EX.MVVM.ViewModels;

namespace TDMPW_412_3P_EX.MVVM.Views;

public partial class MateriaView : ContentPage
{
    public MateriaView()
	{
		InitializeComponent();
        BindingContext = new MateriaViewModel(Navigation);
    }

}
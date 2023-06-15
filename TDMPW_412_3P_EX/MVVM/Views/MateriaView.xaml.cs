using System.Diagnostics;
using TDMPW_412_3P_EX.MVVM.ViewModels;

namespace TDMPW_412_3P_EX.MVVM.Views;

public partial class MateriaView : ContentPage
{
    public MateriaViewModel TodasLasMaterias { get; set; }
    public MateriaView()
	{
		InitializeComponent();
        TodasLasMaterias = new MateriaViewModel(Navigation);
        BindingContext = TodasLasMaterias;
    }

}
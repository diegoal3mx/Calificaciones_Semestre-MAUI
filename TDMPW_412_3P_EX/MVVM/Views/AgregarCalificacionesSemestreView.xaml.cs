using PropertyChanged;
using TDMPW_412_3P_EX.MVVM.ViewModels;

namespace TDMPW_412_3P_EX.MVVM.Views;

[AddINotifyPropertyChangedInterface]
public partial class AgregarCalificacionesSemestreView : ContentPage
{
	public AgregarCalificacionesSemestreView(SemestreViewModel TodosLosSemestres)
	{
		InitializeComponent();
        BindingContext = new AgregarCalificacionesSemestreViewModel(Navigation, TodosLosSemestres);
    }
}
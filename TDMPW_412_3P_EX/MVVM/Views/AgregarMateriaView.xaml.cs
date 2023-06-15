using TDMPW_412_3P_EX.MVVM.ViewModels;

namespace TDMPW_412_3P_EX.MVVM.Views;

public partial class AgregarMateriaView : ContentPage
{
	public AgregarMateriaView(MateriaViewModel TodasLasMaterias)
	{
		InitializeComponent();
		BindingContext = new AgregarMateriaViewModel(Navigation, TodasLasMaterias);
    }
}
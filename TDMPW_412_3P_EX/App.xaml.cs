using TDMPW_412_3P_EX.MVVM.Views;

namespace TDMPW_412_3P_EX;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new Inicio());
    }
}

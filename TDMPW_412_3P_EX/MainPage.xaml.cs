using System.Collections.ObjectModel;

namespace TDMPW_412_3P_EX;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Student> Items { get; } = new();
    public MainPage()
    {
        InitializeComponent();

      
            Items.Add(new Student
            {
                Id = 0,
                Name = "Person " + 0,
                Age = 5,
            });
        
        BindingContext = this;
    }
   
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

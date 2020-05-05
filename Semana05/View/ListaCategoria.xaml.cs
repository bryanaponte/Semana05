using Semana05.ViewModel;
using System.Windows;

namespace Semana05.View
{
    /// <summary>
    /// Lógica de interacción para ListaCategoria.xaml
    /// </summary>
    public partial class ListaCategoria : Window
    {

        ListaCategoriaViewModel viewModel;
        public ListaCategoria()
        {

            InitializeComponent();
            viewModel = new ListaCategoriaViewModel();
            this.DataContext = viewModel;
        }
    }
}

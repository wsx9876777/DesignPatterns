using Memento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Memento
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Caretaker _careraker = new Caretaker();
        Originator _originator = new Originator();
        int _current = 0;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            _current++;
            _originator.Text = TextBox1.Text;
            _careraker.AddMemento(_originator.StoreInMemento());
            label.Content = _current.ToString();
        }

        private void Redo_Click(object sender, RoutedEventArgs e)
        {
            if (_current<_careraker.Count)
            {
                var memento = _careraker[_current];
                TextBox1.Text = _originator.GetFromMemento(memento);
                _current++;
                label.Content = _current.ToString();
            }
        }

        private void Undo_Click(object sender, RoutedEventArgs e)
        {
            if (_current > 0)
            {
                _current--;
                label.Content = _current.ToString();
                if (_current == 0)
                {
                    TextBox1.Text = "";
                    return;
                }
                
                var memento = _careraker[_current];
                TextBox1.Text = _originator.GetFromMemento(memento);
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BitmapImage Image;

        public BitmapImage Img
        {
            get { return Image; }
            set { Image = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            FileInfo fileInfo = new FileInfo("cfk4sqzk966f2i2edzps.jpg");
            Img = new BitmapImage(new Uri(fileInfo.FullName));
        }
    }
}

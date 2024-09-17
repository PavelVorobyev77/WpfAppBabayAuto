using Microsoft.EntityFrameworkCore;
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
using System.Windows.Shapes;
using WpfAppBabayAuto.Models;

namespace WpfAppBabayAuto.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdmMenu.xaml
    /// </summary>
    public partial class AdmMenu : Window
    {
        private readonly Pz1VorobyevGlazirinPr21102Context context;
        public AdmMenu()
        {
            InitializeComponent();
            context = new Pz1VorobyevGlazirinPr21102Context();

            var users = context.Users.ToList();
            admDg.ItemsSource = users;

        }
    }
}

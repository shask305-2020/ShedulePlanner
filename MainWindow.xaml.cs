using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExRaspViewer.Classes;
using ShedulePlanner.Model;

namespace ShedulePlanner
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*
        private SqlConnection _connection;
        private ClassSqlDB data = new ClassSqlDB();
        private ClassOleDB oleDB = new ClassOleDB();
        private Service service = new Service();
        private List<Service> servicesList = new List<Service>();

        private SqlCommandBuilder builderGroup;
        private SqlCommandBuilder builderPrep;
        private SqlDataAdapter adapterGroup;
        private SqlDataAdapter adapterPrep;
        private DataSet dsGroup;
        private DataSet dsPrep;

        private int semestr;    //Семестр
        private int tekNed = 4; //Текущая неделя
        private int state = 0;  //если 0, то данные сохранены, 1 - данные еще не сохранены

        */


        public MainWindow()
        {
            InitializeComponent();
            LoadGroup();
        }

        //Загрузка списка групп в ListBox
        private void LoadGroup()
        {
            listGroup.Items.Clear();
            listGroup.ItemsSource = ExRaspisDBEntities.GetContext().SPGRUP.ToList();
            listGroup.DisplayMemberPath = "NAIM";
            listGroup.SelectedValuePath = "IDG";
            listGroup.Items.SortDescriptions.Clear();
            listGroup.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("NAIM", System.ComponentModel.ListSortDirection.Ascending));
        }

        private void listGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(listGroup.SelectedValue.ToString());
        }
    }
}

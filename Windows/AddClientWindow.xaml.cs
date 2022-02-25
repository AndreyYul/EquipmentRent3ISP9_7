using EquipmentRent3ISP9_7.EF;
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

namespace EquipmentRent3ISP9_7.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        bool isEdit;
        Client editClient = new Client();

        public AddClientWindow()
        {
            InitializeComponent();
            cmbGender.ItemsSource = HelperClass.HelperCl.Context.Gender.ToList();
            cmbGender.DisplayMemberPath = "GenderName";
            cmbGender.SelectedIndex = 0;
        }

        public AddClientWindow(Client client)
        {
            InitializeComponent();

            // Заполнение полей свойствами аргумента employee 
            cmbGender.ItemsSource = HelperClass.HelperCl.Context.Gender.ToList();
            cmbGender.DisplayMemberPath = "GenderName";


            txtLname.Text = client.LastName;
            txtFname.Text = client.FirstName;
            txtMname.Text = client.MiddleName;
            txtEmail.Text = client.Email;
            txtPhone.Text = client.Phone;
            dpBirthday.SelectedDate = client.Birthday;
            txtPassport.Text = client.IdPassport.ToString();

            cmbGender.SelectedIndex = client.IdGender - 1;

            tbTitle.Text = "Изменение данных клиента";
            btnAddNew.Content = "Сохранить";

            isEdit = true;
            // Сохраняем employee для доступа вне конструктора
            editClient = client;
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using WebApplication1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        private readonly HttpClient _client = new HttpClient();
        public MainWindow()
        {
            InitializeComponent();
            _client.BaseAddress = new Uri("https://localhost:44375/api/");
            LoadDataAsync();
        }
        private async Task<List<User>> GetUsersAsync()
        {
            List<User> users = new List<User>();
            try
            {
                HttpResponseMessage response = await _client.GetAsync("users");
                if (response.IsSuccessStatusCode)
                {
                    var usersJson = await response.Content.ReadAsStringAsync();
                    users = JsonConvert.DeserializeObject<List<User>>(usersJson);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении данных: {ex.Message}");
            }
            return users;
        }
        private async void LoadDataAsync()
        {
            try
            {
                var users = await GetUsersAsync();
                dataGrid.ItemsSource = users; 
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Ошибка при получении данных: " + ex.Message);
            }
        }

       
    }


    }

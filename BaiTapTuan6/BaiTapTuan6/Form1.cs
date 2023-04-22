using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Formatting;
namespace BaiTapTuan6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayInDataGridView(object tasks, string option)
        {
            
        }
        private async void btnGetList_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos");
            if (response.IsSuccessStatusCode == true)
            {
                string jsonContent = await response.Content.ReadAsStringAsync();
                List<ToDoTask> tasks = JsonConvert.DeserializeObject<List<ToDoTask>>(jsonContent);
                displayInDataGridView((object)tasks, "option1");
            }
        }

        private async void btnGetListOutside_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://svcy.myclass.vn/api/ToDoList/GetAllTask");
            if (response.IsSuccessStatusCode == true)
            {
                string jsonContent = await response.Content.ReadAsStringAsync();
                List<ToDoList2> tasks = JsonConvert.DeserializeObject<List<ToDoList2>>(jsonContent);
                displayInDataGridView(tasks, "option2");
            }
        }

        private async void btnAddToDoList_Click(object sender, EventArgs e)
        {
            //tạo 1 đối tượng mới
            if (txtTaskName.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống task name");
                return;
            }
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống Status");
                return;
            }
            if (!(string.Equals(textBox2.Text, "true") || string.Equals(textBox2.Text, "false")))
            {
                MessageBox.Show("Status chỉ được nhập 2 giá trị là true hoặc false");
                return;
            }
            bool status = textBox2.Text == "true" ? true : false;
            MessageBox.Show(textBox2.Text);
            HttpClient client = new HttpClient();
            var parameters = new Dictionary<string, string> {
                { "taskName", $"{txtTaskName.Text}" },
                {"status", $"{status.ToString()}" }
            };
            var content = new FormUrlEncodedContent(parameters);
            HttpResponseMessage response = await client.PostAsync("http://svcy.myclass.vn/api/ToDoList/AddTask", content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Gửi dữ liệu thành công");
            }
            else
            {
                MessageBox.Show("Gửi dữ liệu thất bại: " + response.StatusCode);
            }
            txtTaskName.Clear();
            textBox2.Clear();
        }
    }
}

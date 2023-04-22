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
            
        }
    }
}

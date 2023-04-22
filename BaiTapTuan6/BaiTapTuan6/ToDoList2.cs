using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTuan6
{
    internal class ToDoList2
    {
        public string taskName { get; set; }
        public bool status { get; set; }
        public ToDoList2(string taskName, bool status)
        {
            this.taskName = taskName;
            this.status = status;
        }
    }
}

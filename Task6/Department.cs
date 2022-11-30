using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Department
    {
        private string departmentName;
        private int empsMaxCount { get; set; }

        public string getDepartmentName()
        {
            return departmentName;
        }

        public int getEmpsMaxCount()
        {
            return empsMaxCount;
        }

        public Department(string depName, int empMaxCount)
        {
            this.departmentName = depName;
            this.empsMaxCount = empMaxCount;
        }
    }
}

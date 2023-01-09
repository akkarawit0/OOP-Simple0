using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Simple0
{
    public class Student
    {
        public string _Name;
        public string _ID;
        public int _Yeay;
        public double _Hight;
        public double _Grade;
        public string _Major;

        public void AddData(DataGridView gridView)
        {
            gridView.Rows.Add(_Name, _ID, _Yeay, _Hight, _Grade, _Major);
        }

        



    }
}

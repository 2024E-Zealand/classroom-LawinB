using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class student
    {
        public string name {  get; private set; }
        public int birthmonth { get; private set; }
        public int birthday { get; private set; }

        public student(string name, int birthmonth, int birthday)
        {
            this.name = name;
            this.birthmonth = birthmonth;
            this.birthday = birthday;
        }
    }
}

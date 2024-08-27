using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class Classroom
    {
        public string Classname { get; set; }
        public List <student> studentlist { get; set; }
        public DateTime semesterstart { get; set; }

        public Classroom()
        {
           
        }
    }
}

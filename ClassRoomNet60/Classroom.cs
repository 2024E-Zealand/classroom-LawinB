using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class Classroom
    {
        public string Classname { get; private set; }
        public List <student> studentlist { get; private set; }
        public DateTime semesterstart { get; private set; }

        public Classroom(string classname, List<student> studentlist, DateTime semesterstart)
        {
            Classname = classname;
            this.studentlist = studentlist;
            this.semesterstart = semesterstart;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Nachklausur
{
    public class Student
    {
        string vname, nname, gdatum, addrese;

        public Student(string vnamen, string nnamen, string gdatums, string addressen)
        {
            this.vname = vnamen;
            this.nname = nnamen;
            this.gdatum = gdatums;
            this.addrese = addressen;
        }

        public string toCSV()
        {
            string s;

            s = string.Format($"{vname};{nname};{gdatum};{addrese}");
            return s;
        }

        public string Vname { get => vname; set => vname = value; }
        public string Nname { get => nname; set => nname = value; }
        public string Gdatum { get => gdatum; set => gdatum = value; }
        public string Addrese { get => addrese; set => addrese = value; }
    }
}

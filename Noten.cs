using System;
using System.Collections.Generic;
using System.Text;
//timon
namespace Nachklausur
{
    public class Noten
    {
        private string name, fach, note;

        public Noten(string namen, string fachern, string noten)
        {
            this.name = namen;
            this.fach = fachern;
            this.note = noten;
        }

        public string Fach { get => fach; set => fach = value; }
        public string Note { get => note; set => note = value; }
        public string Name { get => name; set => name = value; }
    }
}

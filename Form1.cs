using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Nachklausur
{
    public partial class Form1 : Form
    {
        private List<Student> listStud = new List<Student>();
        private List<Noten> listNot = new List<Noten>();
        private int anzNot;

        public Form1()
        {
            InitializeComponent();

            liesStud();
        }

        private void liesStud()
        {

            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                if (File.Exists("Studenten.csv"))
                {
                    fs = new FileStream("Studenten.csv", FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string s;

                    lisBoxStud.Items.Clear();

                    while (sr.Peek() != -1)
                    {
                        s = sr.ReadLine();

                        string[] Studi = s.Split(';');
                        listStud.Add(new Student(Studi[0], Studi[1], Studi[2], Studi[3]));
                    }

                    zeigStud();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sr != null)
                    sr.Close();
                if (fs != null)
                    fs.Close();
            }
        }

        private void butStudSpeich_Click(object sender, EventArgs e)
        {
            listStud.Add(new Student(texBoxVNam.Text, texBoxNName.Text, texBoxGDat.Text, texBoxAddr.Text));

            zeigStud();
            sichStud();
        }

        private void zeigStud()
        {
            lisBoxStud.Items.Clear();
            foreach (Student s in listStud)
                lisBoxStud.Items.Add($"{s.Vname};{s.Nname};{s.Gdatum};{s.Addrese}");
        }

        private void sichStud()
        {
            FileStream fs = new FileStream("Studenten.csv", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            foreach (Student s in listStud)
                sw.WriteLine(s.toCSV());

            sw.Close();
            fs.Close();
        }

        private void butSpeichNot_Click(object sender, EventArgs e)
        {
            string s;

            s = lisBoxStud.SelectedItem.ToString();
            string[] Names = s.Split(';');

            listNot.Add(new Noten(Names[0], comBoxNot.Text, texBoxNot.Text));
            anzNot++;

            zeigNot();
            zeigAnz();
        }

        private void zeigAnz()
        {
            labAnz.Text = Convert.ToString(anzNot);
        }

        private void zeigNot()
        {
            lisBoxNot.Items.Clear();
            foreach (Noten n in listNot)
                lisBoxNot.Items.Add($"{n.Name};{n.Fach};{n.Note}");
        }
    }
}

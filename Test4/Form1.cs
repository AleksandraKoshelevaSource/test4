using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test4
{
    public partial class Form1 : Form
    {
        string s = "TestString!";
        string s2 = "TestString2!";
        public Form1()
        {
            InitializeComponent();
        }

        public string S2 { get => s2; set => s2 = value; }
    }
}

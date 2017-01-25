using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class Form1 : Form
    {
        //TODO create global list to store user guesses

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //launch the Main Screen
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);
        }
    }
}

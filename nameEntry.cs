using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackJackForm
{
    public partial class nameEntry : Form
    {
        public nameEntry()
        {
            InitializeComponent();
        }

        public static string playerName = "";

        private void submitName(object sender, EventArgs e)
        {
            setName();
        }
        private void setName()
        {
            playerName = playerNameBox.Text;
            this.Close();
        }

        private void keyPress(object sender, KeyEventArgs e)
        {
            //Console.WriteLine(e.KeyValue);
            if(e.KeyValue == 13) { setName(); };
        }
    }
    }
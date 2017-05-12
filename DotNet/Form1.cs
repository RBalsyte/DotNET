using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sender.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = addressList.Text;
            string[] addresses = text.Split(',');

            Ping pinger = new Ping();
            for (int i = 0; i < addresses.Length; i++)
            {
                dataGridView1.Rows.Add(addresses[i]);
            }

            try
            {
                PingReply replyer = pinger.Send(addresses[0]);
                Console.WriteLine(replyer.Status);
            }
            catch (PingException)
            {
                Console.WriteLine("Invalid address!");
            }
        }
    }
}

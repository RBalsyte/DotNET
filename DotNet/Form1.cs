using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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
            button1.Enabled = false;

            string text = addressList.Text;
            string[] addresses = text.Split(',');

            for (int i = 0; i < addresses.Length; i++)
            {
                dataGridView1.Rows.Add(addresses[i].Trim(), "Not Pinged", "Not Cheked", "Not Checked", "0");
            }

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                /* run your code here */
                Parallel.For(0, addresses.Length, i =>
                {
                    pingAndCheckPort(addresses[i].Trim(), i);
                });
            }).Start();

        }

        private void pingAndCheckPort(string address, int row)
        {
            Ping pinger = new Ping();
            PingReply replyer;
            int attempts = 0;
            try
            {
                bool checkedPorts = false;

                while (attempts < 5)
                {
                    Console.WriteLine("Attempt number " + attempts);
                    replyer = pinger.Send(address);
                    // Show success status on UI, check ports and continue pinging
                    Console.WriteLine("Address " + address + " pinged with status " + replyer.Status);

                    dataGridView1.Rows[row].Cells[1].Value = replyer.Status.ToString();
                    if (replyer.Status.ToString().Equals("Success")) {
                        dataGridView1.Rows[row].Cells[4].Value = replyer.RoundtripTime.ToString();
                    }

                    if (replyer.Status.ToString().Equals("Success") && !checkedPorts)
                    {
                        if (checkPort(address, 80))
                        {
                            // Show on UI that port is open
                            dataGridView1.Rows[row].Cells[2].Value = "Open";
                        }
                        else
                        {
                            // Show on UI that port is closed
                            dataGridView1.Rows[row].Cells[2].Value = "Closed";
                        }

                        if (checkPort(address, 8080))
                        {
                            // Show on UI that port is open
                            dataGridView1.Rows[row].Cells[3].Value = "Open";
                        }
                        else
                        {
                            // Show on UI that port is closed
                            dataGridView1.Rows[row].Cells[3].Value = "Closed";
                        }

                        checkedPorts = true;
                    }

                    // Proceed with checking the ports
                    Thread.Sleep(500);
                    attempts = attempts + 1;
                    // Proceed with checking the ports
                    Invoke(new MethodInvoker(() => {
                        dataGridView1.Update();
                    }));

                }

            }
            catch (PingException)
            {
                dataGridView1.Rows[row].Cells[1].Value = "Invalid address";
                Console.WriteLine("Invalid address!");
            }
        }

        private bool checkPort(String address, int port)
        {
            TcpClient tcpClient = new TcpClient();
            try
            {
                var result = tcpClient.BeginConnect(address, port, null, null);
                var success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1));
                if (!success)
                {
                    Console.WriteLine("Port " + port + "on addr " + address + " Closed");
                    return false;
                }

                tcpClient.EndConnect(result);
                Console.WriteLine("Port " + port + "on addr " + address + " Open");
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Port " + port + "on addr " + address + " Closed");
            }
            return false;
        }

    }
}

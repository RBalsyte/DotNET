using System;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNet
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cts;

        public Form1()
        {
            InitializeComponent();
            addressList.KeyDown += new KeyEventHandler(addressList_KeyDown);

            int workerThreads;
            int portThreads;
            ThreadPool.GetMaxThreads(out workerThreads, out portThreads);
            Console.WriteLine("Maximum Worker Thread Count = " + workerThreads);
            Console.WriteLine("Maximum Completion Port Thread Count = " + portThreads);
            statusMaxWorkerThreads.Text = workerThreads.ToString();
            statusMaxPortThreads.Text = portThreads.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sender.ToString();
        }

        private void startPing()
        {
            if (cts != null)
            {
                cts.Cancel();
            }

            string text = addressList.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                return;
            }

            // Split, trim and remove empty entries
            string[] addresses = text.Split(',').Select(p => p.Trim()).ToArray();
            addresses = addresses.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            if (addresses.Length < 0)
            {
                return;
            }

            pingButton.Enabled = false;

            // Update Address List in the GUI
            dataGridView1.Rows.Clear();
            for (int i = 0; i < addresses.Length; i++)
            {
                dataGridView1.Rows.Add(addresses[i].Trim(), "Not Pinged", "Not Cheked", "Not Checked", "0");
            }

            cts = new CancellationTokenSource();
            ParallelOptions po = new ParallelOptions();
            po.CancellationToken = cts.Token;

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                /* run your code here */
                try
                {
                    Parallel.For(0, addresses.Length, po, i =>
                    {
                        pingAndCheckPort(addresses[i].Trim(), i, po);
                    });

                    // All addresses were invalid or exited without being cancelled
                    updateAvailableThreadCount(true);
                }
                catch (OperationCanceledException)
                {
                    // Ping cancelled -> all running threads are stopped -> update GUI
                    updateAvailableThreadCount(true);
                }
            }).Start();
        }

        private void pingAndCheckPort(string address, int row, ParallelOptions po)
        {
            if (string.IsNullOrEmpty(address) || address.Length > 255)
            {
                // Update GUI and stop pinging the invalid address
                BeginInvoke(new MethodInvoker(() =>
                {
                    Console.WriteLine("Invalid address!");
                    dataGridView1.Rows[row].Cells[1].Value = "Invalid address";
                    dataGridView1.Update();
                }));

                return;
            }

            Ping pinger = new Ping();
            PingReply replyer;

            try
            {
                bool portsChecked = false;

                while (!po.CancellationToken.IsCancellationRequested)
                {
                    updateAvailableThreadCount(false);

                    replyer = pinger.Send(address);

                    // Update ping info for this address
                    Console.WriteLine("Address " + address + " pinged with status " + replyer.Status);
                    dataGridView1.Rows[row].Cells[1].Value = replyer.Status.ToString();

                    if (replyer.Status == IPStatus.Success)
                    {
                        dataGridView1.Rows[row].Cells[4].Value = replyer.RoundtripTime.ToString();
                    }

                    if (replyer.Status == IPStatus.Success && !portsChecked)
                    {
                        dataGridView1.Rows[row].Cells[2].Value = checkPort(address, 80) ? "Open" : "Closed";
                        dataGridView1.Rows[row].Cells[3].Value = checkPort(address, 8080) ? "Open" : "Closed";
                        portsChecked = true;
                    }

                    // Wait before checking again
                    Thread.Sleep(500);

                    // Refresh GUI
                    BeginInvoke(new MethodInvoker(() =>
                    {
                        dataGridView1.Update();
                    }));
                }
            }
            catch (PingException)
            {
                // Update GUI and stop pinging the invalid address
                BeginInvoke(new MethodInvoker(() =>
                {
                    Console.WriteLine("Invalid address!");
                    dataGridView1.Rows[row].Cells[1].Value = "Invalid address";
                    dataGridView1.Update();
                }));
            }
        }

        private bool checkPort(string address, int port)
        {
            TcpClient tcpClient = new TcpClient();
            try
            {
                var result = tcpClient.BeginConnect(address, port, null, null);
                bool success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1));
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

        private void pingButton_Click(object sender, EventArgs e)
        {
            startPing();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
            }
        }

        private void addressList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startPing();
            }
        }

        private void updateAvailableThreadCount(bool resetButton)
        {
            BeginInvoke(new MethodInvoker(() =>
            {
                if (resetButton)
                {
                    pingButton.Enabled = true;
                }

                int workerThreads;
                int portThreads;
                ThreadPool.GetAvailableThreads(out workerThreads, out portThreads);
                statusAvailableWorkerThreads.Text = workerThreads.ToString();
                statusAvailablePortThreads.Text = portThreads.ToString();
            }));
        }
    }
}

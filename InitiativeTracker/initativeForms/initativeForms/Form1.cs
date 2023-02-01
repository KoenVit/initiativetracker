using System;
using System.Data.Common;
using System.IO.Ports;
using System.Windows.Forms;

namespace initativeForms
{
    public partial class initiativeTrackerForm : Form
    {
        private Connection? connection;
        private SerialPort? testPort;
        private List<Player> players = new List<Player>();
        public initiativeTrackerForm()
        {
            InitializeComponent();
        }

        private string CreateMessage()
        {
            string message = "N";
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.Rows.Count < 4)
                {
                    message += dataGridView1.Rows.Count + ":";
                }
                else
                {
                    message += "4:";
                }

                int i = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    message += row.Cells[0].Value.ToString();
                    i++;
                    if (i >= 4)
                    {
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please add more players");
            }
            return message;
        }

        private void SortInitiative()
        {
            dataGridView1.Sort(dataGridView1.Columns["initiativeColumn"], System.ComponentModel.ListSortDirection.Descending);
            dataGridView1.ClearSelection();
            dataGridView1.Rows[0].Selected = true;
        }

        private void SendToArduino(string message)
        {
            if (connection != null && connection.Port != null)
            {
                try
                {
                    connection.Port.Open();
                    connection.Port.WriteLine(message);
                    string readData = connection.Port.ReadLine();
                    if (!readData.Contains('@'))
                    {
                        MessageBox.Show("Could not update");
                    }
                }
                catch (InvalidOperationException exception)
                {
                    MessageBox.Show(exception.Message);
                }
                catch (IOException exception)
                {
                    MessageBox.Show(exception.Message);
                    connectionLabel.Text = "Not connected!";
                }
                finally
                {
                    connection.Port.Close();
                }
            }
            else
            {
                MessageBox.Show("No connection with Arduino");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (typeCombobox.SelectedIndex == 0)
            {
                if (initialTextbox.Text.Length == 2)
                {
                    dataGridView1.Rows.Add(initialTextbox.Text.ToUpper(), initiativeNumeric.Value);
                }
                else
                {
                    MessageBox.Show("Please enter two initials");
                    return;
                }
            }
            else if (typeCombobox.SelectedIndex == 1)
            {
                dataGridView1.Rows.Add(enemyNumeric.Value, initiativeNumeric.Value);
            }
        }

        private void typeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (typeCombobox.SelectedIndex)
            {
                case 0:
                    initialTextbox.Enabled = true;
                    enemyNumeric.Enabled = false;
                    initiativeNumeric.Enabled = true;
                    break;
                case 1:
                    enemyNumeric.Enabled = true;
                    initialTextbox.Enabled = false;
                    initiativeNumeric.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ports = Connection.GetPorts();
                foreach (string port in ports)
                {
                    testPort = new SerialPort(port, 9600);
                    testPort.NewLine = "\n";
                    testPort.ReadTimeout = 5000;
                    testPort.Open();
                    testPort.WriteLine("C?");
                    string readData = testPort.ReadLine();
                    if (readData.Contains('@'))
                    {
                        connection = new(testPort);
                        connectionLabel.Text = "Connected!";
                        break;
                    }
                }
            }
            catch (InvalidOperationException exception)
            {
                MessageBox.Show("Arduino could not be found: {0}", exception.Message);
            }
            catch (IOException exception)
            {
                MessageBox.Show("Could not connect to Arduino: {0}", exception.Message);
                connectionLabel.Text = "Not connected!";
            }
            finally
            {
                if (testPort != null)
                {
                    if (testPort.IsOpen)
                    {
                        testPort.Close();
                    }
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row= dataGridView1.Rows[0];
            dataGridView1.Rows.RemoveAt(0);
            dataGridView1.Rows.Add(row);

            SendToArduino(CreateMessage());
        }

        private void killButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            }
            else
            {
                MessageBox.Show("Please select the whole row");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Are you sure?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
                startButton.Enabled = true;
            }
            else
            {
                return;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SortInitiative();
            SendToArduino(CreateMessage());
            startButton.Enabled = false;
        }
    }
}
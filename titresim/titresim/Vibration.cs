using System.IO.Ports;

namespace titresim
{
    public partial class Vibration : Form
    {
        string[] ports;
        public Vibration()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            baglan.Enabled = false;
            baglatiDurumui.Text = "Baðlantý kurulmadý...";
            start.Enabled = false;
            int[] num = { 1, 2, 3 };
            for (int i = 0; i<4; i++)
            {
                comboBox2.Items.Add(i);
                comboBox3.Items.Add(i);
                comboBox4.Items.Add(i);
                comboBox5.Items.Add(i);
                comboBox6.Items.Add(i);
                comboBox7.Items.Add(i);
                comboBox8.Items.Add(i);
                comboBox9.Items.Add(i);
            }
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            portTara();
        }
        public void portTara()
        {
            comboBox1.Items.Clear();
            ports = SerialPort.GetPortNames();
            
            if(ports.Length > 0)
            {
                baglan.Enabled = true;  
            }
            else
            {
                baglan.Enabled=false;
            }
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
            comboBox1.SelectedIndex = 0;
        }
        SerialPort port;
        private void baglan_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
                MessageBox.Show("Önce baðlantý seçin.");
            else
            {
                try
                {

                    if (port!=null && port.IsOpen)
                    {
                        port.Close();
                    }
                    port = new SerialPort();
                    port.BaudRate = 9600;
                    port.PortName = ports[comboBox1.SelectedIndex].ToString();
                    port.Open();
                    baglatiDurumui.Text = "Baðlandý...";
                    
                    //MessageBox.Show(ports[comboBox1.SelectedIndex]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    baglatiDurumui.Text = "Baðlantý hatasý";
                }
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            try
            {
                port.Write("9");
                port.Write("9");
                port.Write("9");
                port.Write("9");
                port.Write("9");
                port.Write("9");
                port.Write("9");
                port.Write("9");
                port.Write("9");
                port.Write("9");
                port.Write("9");
                port.Write("9");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Encountered error while writing to / or reading from serial port");
                Console.WriteLine(ex.ToString());
                baglatiDurumui.Text = "Baðlantý hatasý";
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                if (motor1.Checked)
                {
                    port.Write("8");
                    port.Write(comboBox2.SelectedIndex.ToString());
                    port.Write(comboBox6.SelectedIndex.ToString());
                }
                else
                {
                    port.Write("9");
                    port.Write("9");
                    port.Write("9");
                }
                if (motor2.Checked)
                {
                    port.Write("7");
                    port.Write(comboBox3.SelectedIndex.ToString());
                    port.Write(comboBox7.SelectedIndex.ToString());
                }
                else
                {
                    port.Write("9");
                    port.Write("9");
                    port.Write("9");
                }
                if (motor3.Checked)
                {
                    port.Write("6");
                    port.Write(comboBox4.SelectedIndex.ToString());
                    port.Write(comboBox8.SelectedIndex.ToString());
                }
                else
                {
                    port.Write("9");
                    port.Write("9");
                    port.Write("9");
                }
                if (motor4.Checked)
                {
                    port.Write("5");
                    port.Write(comboBox5.SelectedIndex.ToString());
                    port.Write(comboBox9.SelectedIndex.ToString());
                }
                else
                {
                    port.Write("9");
                    port.Write("9");
                    port.Write("9");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Encountered error while writing to / or reading from serial port");
                Console.WriteLine(ex.ToString());
                baglatiDurumui.Text = "Baðlantý hatasý";
            }
        }

        private void tara_Click(object sender, EventArgs e)
        {
            portTara();
        }
        public void kontrol()
        {
            if(motor1.Checked || motor2.Checked || motor3.Checked || motor4.Checked)
            {
                start.Enabled = true;
            }
            else
                start.Enabled=false;
        }
        private void motor1_CheckedChanged(object sender, EventArgs e)
        {
            kontrol();
        }

        private void motor2_CheckedChanged(object sender, EventArgs e)
        {
            kontrol();
        }

        private void motor3_CheckedChanged(object sender, EventArgs e)
        {
            kontrol();
        }

        private void motor4_CheckedChanged(object sender, EventArgs e)
        {
            kontrol();
        }
    }
}
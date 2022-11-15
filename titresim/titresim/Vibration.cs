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
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox7.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox8.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox9.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            comboBox8.Enabled = false;
            comboBox9.Enabled = false;
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
            try
            {
                comboBox1.Items.Clear();
                ports = SerialPort.GetPortNames();

                if (ports.Length > 0)
                {
                    baglan.Enabled = true;
                }
                else
                {
                    baglan.Enabled = false;
                }
                foreach (string port in ports)
                {
                    comboBox1.Items.Add(port);
                }
                comboBox1.SelectedIndex = 0;
            }
            catch
            {

            }
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
            if(motor1.Checked)
            {
                comboBox2.Enabled = true;
                comboBox6.Enabled = true;
            }
            else
            {
                comboBox2.Enabled = false;
                comboBox6.Enabled = false;
            }
        }

        private void motor2_CheckedChanged(object sender, EventArgs e)
        {
            kontrol();
            if (motor2.Checked)
            {
                comboBox3.Enabled = true;
                comboBox7.Enabled = true;
            }
            else
            {
                comboBox3.Enabled = false;
                comboBox7.Enabled = false;
            }
        }

        private void motor3_CheckedChanged(object sender, EventArgs e)
        {
            kontrol();
            if (motor3.Checked)
            {
                comboBox4.Enabled = true;
                comboBox8.Enabled = true;
            }
            else
            {
                comboBox4.Enabled = false;
                comboBox8.Enabled = false;
            }
        }

        private void motor4_CheckedChanged(object sender, EventArgs e)
        {
            kontrol();
            if (motor4.Checked)
            {
                comboBox5.Enabled = true;
                comboBox9.Enabled = true;
            }
            else
            {
                comboBox5.Enabled = false;
                comboBox9.Enabled = false;
            }
        }

        private void mod_Click(object sender, EventArgs e)
        {
            ModSelector ms = new ModSelector(port);
            ms.ShowDialog();
        }
    }
}
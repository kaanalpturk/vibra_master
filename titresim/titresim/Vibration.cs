using System.Collections;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace titresim
{
    public partial class Vibration : Form
    {
        string[] ports;
        static string path;
        ArrayList modList;
        public Vibration()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            baglatiDurumui.Text = "Baðlantý kurulmadý...";
            start.Enabled = false;
            readFile();
        }
        public void readFile()
        {
            path = "mods.bin";
            listBox1.Items.Clear();
            modList = new ArrayList();
            try
            {
                FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                //dosyadan satýr satýr okuyup textBox içine yazýdýrýyoruz
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    int i = 1;
                    while (true)
                    {
                        string satir = reader.ReadLine();
                        if (satir == null) break;
                        listBox1.Items.Add("Mod "+i);
                        modList.Add(satir);
                        i++;
                        
                    }
                    reader.Close();
                }
                fileStream.Close();
            }
            catch
            {

            }
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
        private void tara_Click(object sender, EventArgs e)
        {
            portTara();
        }
        public void kontrol()
        {
            if(listBox1.SelectedIndex>-1)
            {
                start.Enabled = true;
            }
            else
            {
                start.Enabled = false;
            }
        }

        private void mod_Click(object sender, EventArgs e)
        {
            ModSelector ms = new ModSelector(port);
            ms.ShowDialog();
            readFile();
        }
        string selected;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kontrol();
            selected = modList[listBox1.SelectedIndex].ToString();
        }

        private void start_Click_1(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 12; i++)
                {
                    port.Write(selected[i].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Encountered error while writing to / or reading from serial port");
                Console.WriteLine(ex.ToString());
                baglatiDurumui.Text = "Baðlantý hatasý";
            }
        }

        private void stop_Click_1(object sender, EventArgs e)
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
    }
}
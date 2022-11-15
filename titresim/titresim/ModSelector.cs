using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace titresim
{
    public partial class ModSelector : Form
    {
        SerialPort port;
        static string path;
        public ModSelector(SerialPort sp)
        {
            InitializeComponent();
            port = sp;
            readFile();

        }
        public void readFile()
        {
            path = "mods.bin";
            listBox1.Items.Clear();
            try
            {
                FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                //dosyadan satır satır okuyup textBox içine yazıdırıyoruz
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    int i = 1;
                    while (true)
                    {
                        string satir = reader.ReadLine();
                        if (satir == null) break;
                        listBox1.Items.Add(satir);
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
        private void ModSelector_Load(object sender, EventArgs e)
        {
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
            for (int i = 0; i < 4; i++)
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

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void modEkle_Click(object sender, EventArgs e)
        {
            string row = "";
            if (motor1.Checked)
            {
                row+="8";
                row += comboBox2.SelectedIndex.ToString();
                row += comboBox6.SelectedIndex.ToString();
            }
            else
            {
                row += "9";
                row += "9";
                row += "9";
            }
            if (motor2.Checked)
            {
                row += "7";
                row += comboBox3.SelectedIndex.ToString();
                row+=comboBox7.SelectedIndex.ToString();
            }
            else
            {
                row+="9";
                row+="9";
                row+="9";
            }
            if (motor3.Checked)
            {
                row+="6";
                row+=comboBox4.SelectedIndex.ToString();
                row+=comboBox8.SelectedIndex.ToString();
            }
            else
            {
                row+="9";
                row+="9";
                row+="9";
            }
            if (motor4.Checked)
            {
                row+="5";
                row+=comboBox5.SelectedIndex.ToString();
                row+=comboBox9.SelectedIndex.ToString();
            }
            else
            {
                row+="9";
                row+="9";
                row+="9";
            }
            listBox1.Items.Add(row);
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
                MessageBox.Show("Bağlantı hatası");
            }
        }

        private void modSil_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex>-1){
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        public void kontrol()
        {
            if (motor1.Checked || motor2.Checked || motor3.Checked || motor4.Checked)
            {
                start.Enabled = true;
            }
            else
                start.Enabled = false;
        }
        private void motor1_CheckedChanged(object sender, EventArgs e)
        {
            kontrol();
            if (motor1.Checked)
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
                MessageBox.Show("Bağlantı hatası");
            }
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                string text = "";
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    text += listBox1.Items[i].ToString() + "\n";
                }
                File.WriteAllText(path, text);
                MessageBox.Show("Başarıyla kaydedildi...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Dosyaya yazma sırasında hata meydana geldi!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tmp = "";
            if (listBox1.SelectedIndex>-1){
                tmp = listBox1.Items[listBox1.SelectedIndex].ToString();
                if (tmp[0] != '9')
                {
                    motor1.Checked = true;
                    comboBox2.SelectedIndex = Int32.Parse(tmp[1].ToString());
                    comboBox6.SelectedIndex = Int32.Parse(tmp[2].ToString());
                }
                else
                {
                    motor1.Checked = false;
                }
                if (tmp[3] != '9')
                {
                    motor2.Checked = true;
                    comboBox3.SelectedIndex = Int32.Parse(tmp[4].ToString());
                    comboBox7.SelectedIndex = Int32.Parse(tmp[5].ToString());
                }
                else
                {
                    motor2.Checked = false;
                }
                if (tmp[6] != '9')
                {
                    motor3.Checked = true;
                    comboBox4.SelectedIndex = Int32.Parse(tmp[7].ToString());
                    comboBox8.SelectedIndex = Int32.Parse(tmp[8].ToString());
                }
                else
                {
                    motor3.Checked = false;
                }
                if (tmp[9] != '9')
                {
                    motor4.Checked = true;
                    comboBox5.SelectedIndex = Int32.Parse(tmp[10].ToString());
                    comboBox9.SelectedIndex = Int32.Parse(tmp[11].ToString());
                }
                else
                {
                    motor4.Checked = false;
                }
            }
        }
    }
}

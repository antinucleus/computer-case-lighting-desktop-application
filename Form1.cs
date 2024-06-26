using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace KasaYazılım
{

    public partial class Form1 : Form
    {

        bool[] animationState = new bool[2];
        String frontPanel = "o", casePanel = "k";
        String data;
        bool[] colors = new bool[6];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }

            for (int i = 0; i < 6; i++)
            {
                colors[i] = false;
            }

            animationState[0] = false;
            animationState[1] = false;
            comboBoxmod1.SelectedIndex = 0;
            comboBoxmod2.SelectedIndex = 0;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.SelectedItem.ToString();
            serialPort1.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Threading.Thread.Sleep(50);
            serialPort1.Write("z");
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            colors[0] = !colors[0];
            frontPanelRedBrightness.Visible = !frontPanelRedBrightness.Visible;
            labelk1.Visible = !labelk1.Visible;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            colors[1] = !colors[1];
            frontPanelGreenBrightness.Visible = !frontPanelGreenBrightness.Visible;
            labely1.Visible = !labely1.Visible;
        }



        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            colors[2] = !colors[2];
            frontPanelBlueBrightness.Visible = !frontPanelBlueBrightness.Visible;
            labelm1.Visible = !labelm1.Visible;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            colors[3] = !colors[3];
            casePanelRedBrightness.Visible = !casePanelRedBrightness.Visible;
            labelk2.Visible = !labelk2.Visible;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            colors[4] = !colors[4];
            casePanelGreenBrightness.Visible = !casePanelGreenBrightness.Visible;
            labely2.Visible = !labely2.Visible;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            colors[5] = !colors[5];
            casePanelBlueBrightness.Visible = !casePanelBlueBrightness.Visible;
            labelm2.Visible = !labelm2.Visible;
        }

        private void frontPanelRedBrightness_ValueChanged(object sender, EventArgs e)
        {
            labelk1.Text = frontPanelRedBrightness.Value.ToString();
        }

        private void frontPanelGreenBrightness_ValueChanged(object sender, EventArgs e)
        {
            labely1.Text = frontPanelGreenBrightness.Value.ToString();
        }

        private void frontPanelBlueBrightness_ValueChanged(object sender, EventArgs e)
        {
            labelm1.Text = frontPanelBlueBrightness.Value.ToString();
        }

        private void casePanelRedBrightness_ValueChanged(object sender, EventArgs e)
        {
            labelk2.Text = casePanelRedBrightness.Value.ToString();
        }

        private void casePanelGreenBrightness_ValueChanged(object sender, EventArgs e)
        {
            labely2.Text = casePanelGreenBrightness.Value.ToString();
        }


        private void casePanelBlueBrightness_ValueChanged(object sender, EventArgs e)
        {
            labelm2.Text = casePanelBlueBrightness.Value.ToString();
        }

        private void buttonSendMusic_Click(object sender, EventArgs e)
        {
            if (checkBoxMusicMode.Checked)
            {
                serialPort1.WriteLine("s");
            }
            if (checkBoxMusicMode.Checked == false)
            {
                serialPort1.WriteLine("c");
            }
        }
       
        private void casePanelPower_Click(object sender, EventArgs e)
        {

            casePanel = "k";
            casePanel += Convert.ToInt32(colors[3]).ToString() + Convert.ToInt32(casePanelRedBrightness.Value).ToString("D3") + Convert.ToInt32(colors[4]).ToString() + Convert.ToInt32(casePanelGreenBrightness.Value).ToString("D3") + Convert.ToInt32(colors[5]).ToString() + Convert.ToInt32(casePanelBlueBrightness.Value).ToString("D3");
            serialPort1.WriteLine(casePanel);
            casePanelPowerOff.BackColor = Color.Red;
            casePanelPowerOn.BackColor = Color.Green;
        }

        private void buttonmod2_Click(object sender, EventArgs e)
        {
            if (animationState[1] == false)
            {
                buttonmod2.BackColor = Color.Green;
                animationState[1] = !animationState[1];
                data = "m2" + comboBoxmod2.SelectedIndex.ToString();
                serialPort1.WriteLine(data);
                animationState[1] = true;
            }
        }


        private void stop_Click(object sender, EventArgs e)
        {
            animationState[1] = false;
            buttonmod2.BackColor = Color.Red;
            serialPort1.Write("x");
        }
        private void casePanelPowerOff_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("k000000000000");
            casePanelPowerOff.BackColor = Color.Green;
            casePanelPowerOn.BackColor = Color.Red;
        }

        private void frontPanelPower_Click(object sender, EventArgs e)
        {
            frontPanel = "o";
            frontPanel += Convert.ToInt32(colors[0]).ToString() + Convert.ToInt32(frontPanelRedBrightness.Value).ToString("D3") + Convert.ToInt32(colors[1]).ToString() + Convert.ToInt32(frontPanelGreenBrightness.Value).ToString("D3") + Convert.ToInt32(colors[2]).ToString() + Convert.ToInt32(frontPanelBlueBrightness.Value).ToString("D3");
            serialPort1.WriteLine(frontPanel);
            frontPanelPowerOff.BackColor = Color.Red;
            frontPanelPowerOn.BackColor = Color.Green;
        }

        private void stopAnimation_Click(object sender, EventArgs e)
        {
            animationState[0] = false;
            buttonmod1.BackColor = Color.Red;
            serialPort1.Write("d");
        }
        private void buttonmod1_Click(object sender, EventArgs e)
        {
            if (animationState[0] == false)
            {
                buttonmod1.BackColor = Color.Green;
                data = "m1" + comboBoxmod1.SelectedIndex.ToString();
                serialPort1.WriteLine(data);
                animationState[0] = true;
            }
        }

      
        private void frontPanelPowerOff_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("o000000000000");
            frontPanelPowerOn.BackColor = Color.Red;
            frontPanelPowerOff.BackColor = Color.Green;
        }

        private void buttonPowerFans_Click(object sender, EventArgs e)
        {
            serialPort1.Write("t");
        }


    }
}

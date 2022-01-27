using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Memory;

namespace GrowTrainer
{
    public partial class GrowTrainer : Form
    {

        public Mem m = new Mem();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        

        public GrowTrainer()
        {
            InitializeComponent();
        }

        private void GrowTrainer_Load(object sender, EventArgs e)
        {

            MessageBox.Show("WARNING: BY USING THIS TRAINER, YOU ARE NOW RESPONSIBLE FOR YOUR OWN ACTIONS, WE DO NOT CONDONE ANY OF YOUR ACTIONS NOR ARE RESPONSIBLE FOR IT.", "GrowTrainer Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            

        }

        string ConnectionState = "Disconnected";

        private void btnConnect_Click(object sender, EventArgs e)
        {

            m.OpenProcess("Growtopia.exe");
            if (m.OpenProcess("Growtopia.exe"))
            {

                ConnectionState = "Connected";

                MessageBox.Show("Growtopia successfully connected.", "GrowTrainer", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

        }

        private void cbAntiRespawn_CheckedChanged(object sender, EventArgs e)
        {


            if (cbAntiRespawn.Checked == true)
            {

                m.WriteMemory("base+9270E8", "bytes", "90 90");

                MessageBox.Show("AntiRespawn enabled. Please re-enter the world for it to work properly.", "GrowTrainer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                m.WriteMemory("base+9270E8", "bytes", "4F 6E");

            }


        }

        private void cbModFly_CheckedChanged(object sender, EventArgs e)
        {

            if (cbFastFall.Checked == true)
            {

                m.WriteMemory("base+509137", "bytes", "90 90");

                MessageBox.Show("ModFly enabled. Please re-enter the world for it to work properly.", "GrowTrainer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                m.WriteMemory("base+509137", "bytes", "74 5D");

            }

        }

        private void cbFastFall_CheckedChanged(object sender, EventArgs e)
        {


            if (cbFastFall.Checked == true)
            {

                m.WriteMemory("base+50913F", "bytes", "74 05");

                MessageBox.Show("FastFall enabled. Please re-enter the world for it to work properly.", "GrowTrainer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                m.WriteMemory("base+50913F", "bytes", "75 05");

            }

        }

        private void cbGhost_CheckedChanged(object sender, EventArgs e)
        {




            if (cbGhost.Checked == true)
            {

                m.WriteMemory("base+4A908F", "bytes", "90 90 90");

                MessageBox.Show("Ghost enabled. Please re-enter the world for it to work properly.", "GrowTrainer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                m.WriteMemory("base+4A908F", "bytes", "48 85 C9");

            }

        }

        private void cbGrowz_CheckedChanged(object sender, EventArgs e)
        {





            if (cbGrowz.Checked == true)
            {

                m.WriteMemory("base+4A9921", "bytes", "90 90 90 90");

                MessageBox.Show("Growz enabled. Please re-enter the world for it to work properly.", "GrowTrainer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                m.WriteMemory("base+4A9921", "bytes", "F3 0F SC D1");

            }

        }
    }
}

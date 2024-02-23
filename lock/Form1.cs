using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @lock
{
    public partial class Form1 : Form
    {
        private int trial = 0;
        private string paswd = "abc";
        private string idea;
        private string data;
        private FileStream filestream;
        private StreamReader strReader;
        private StreamWriter strWriter;
        /*
        [DllImport("C:\\Users\\hp\\Desktop\\New folder\\code\\C++\\LOCK dll\\TryDll\\bin\\Debug\\TryDll.dll")]
        static extern bool  save(string filename, string data);
        [DllImport("C:\\Users\\hp\\Desktop\\New folder\\code\\C++\\LOCK dll\\TryDll\\bin\\Debug\\TryDll.dll")]
        static extern string  get(string filename);


        bool n = save("gg","g");
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            paswd = txt_DataInOut.Text;
            txt_DataInOut.Text = "";
            timer1.Stop();
         }
        private string OpenFile(string pswd)
        {
            string encData;
            try
            {
                filestream = new FileStream(@"data.lock", FileMode.Open, FileAccess.Read);
                strReader = new StreamReader(filestream);   
                encData = strReader.ReadToEnd();
                strReader.Close();
                //filestream.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"open File");
                //MessageBox.Show(ex.ToString());
                //MessageBox.Show(ex.GetType().ToString());
                if("System.IO.FileNotFoundException".Equals(ex.GetType().ToString()))
                    filestream = File.Create("data.lock",1024);
                encData = "";
                filestream.Close();
            }
            data = unscramble(encData,toIntArray(pswd));
            return data;
        }
        private void txt_paswd_DoubleClick(object sender, EventArgs e)
        {
            timer1.Start();
            string pswd = txt_paswd.Text;
            if (pswd.Equals(paswd))
            {
                /// TODO Get file
                txt_DataInOut.Text = OpenFile(pswd);
            }
            else
            {
                if (trial < 3 )
                {
                    Console.Beep();
                    MessageBox.Show("Wrong !!! Try Again");
                    trial++;
                }
                else
                {
                    Application.Exit();
                }

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SaveExit(paswd);
        }
        private void SaveExit(string pwd)
        {
            try
            {
                if(filestream!= null)
                    filestream.Close();
                File.Delete("data.lock");
                filestream = File.Create("data.lock", 1024);
                strWriter = new StreamWriter(filestream);

                try
                {
                    if (txt_DataInOut.Text != data && txt_DataInOut.Text == "")
                        strWriter.Write(scramble(data, toIntArray(pwd)));
                    else
                        strWriter.Write(txt_DataInOut.Text);
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"save file");
            }
            Application.Exit();
        }

        private void txt_DataInOut_DoubleClick(object sender, EventArgs e)
        {
            // Save data if any change
            int[] cy = toIntArray("Plmzaq&oknxsw2");
            string s = scramble(txt_DataInOut.Text, cy);
            string uns = unscramble(s , cy);
            txt_DataInOut.Text = Convert.ToString(s );
            txt_DataInOut.Text = txt_DataInOut.Text + "\n"+uns;

        }

        private string scramble(string s,int[] cypher)
        {
            char [] s2 = s.ToCharArray();
            string scrambled = "";
            
            for (int i = 0,j=0; i < s2.Length;j++, i++) 
            {
                s2[i] = Convert.ToChar( Convert.ToInt32( s2[i] ) + cypher[j]);
                if (cypher.Length-1 == j)
                {
                    j = -1;
                }
            
            }
            for (int i = 0; i < s2.Length; i++)
            {
                scrambled += s2[i];
            }
            return scrambled;
        }
        private string unscramble(string s, int[] cypher)
        {
            char[] s2 = s.ToCharArray();
            string unscrambled = "";
            
            for (int i = 0, j = 0; i < s2.Length; j++, i++)
            {
                s2[i] = Convert.ToChar(Convert.ToInt32(s2[i]) - cypher[j]);
                if (cypher.Length - 1 == j)
                {
                    j = -1;
                }

            }
            for (int i = 0; i < s2.Length; i++)
            {
                unscrambled += s2[i];
            }
            return unscrambled;
        }
        private int[] toIntArray(string s)
        {
            int[] array = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                array[i] = Convert.ToInt32(s[i]);
            }
            return array;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveExit(paswd);
        }
        
    }
}

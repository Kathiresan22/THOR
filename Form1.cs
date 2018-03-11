using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thor
{
    public partial class Form1 : Form
    {
        String imgpath,tesspath,outpath;
        public Form1()
        {
            InitializeComponent();
            ChangeLan();
        }
       

        private void imgselectbtn_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                //textBox1.Text = open.FileName;
                imgpath = open.FileName;
                Console.WriteLine(imgpath);
            }
        }

        private void convert_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                // You can start any process, HelloWorld is a do-nothing example.
                //String outpath = @"E:\THOR\Testing\out";
                //String tesspath = @"C:\Program Files (x86)\Tesseract-OCR\tesseract.exe";
                String param=imgpath+" "+outpath+" -l tam";
                Console.WriteLine(tesspath);
                Console.WriteLine(param);


                Process process = new Process();
                process.StartInfo.FileName = tesspath;
                process.StartInfo.Arguments = param;
                process.StartInfo.WorkingDirectory = @"C:\Program Files (x86)\Tesseract-OCR\";
                process.Start();

                //Thread.Sleep(3000);
                readFile();
                
            }
            catch (Exception exe)
            {
                Console.WriteLine(exe.Message);
            }
        }

        public void readFile()
        {
            // File.ReadAllText(@"E:\THOR\Testing\out", Encoding.UTF8);
            // outputTextBox.Text= File.ReadAllText(@"E:\THOR\Testing\out.txt", Encoding.UTF8);

            
            var fileStream = new FileStream(outpath, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                outputTextBox.Text = streamReader.ReadToEnd();
            }
        }
        private InputLanguage GetTamilLang()
        {
            //Enumerate through InstalledInputLanguages which contains 
            //all the keyboard layout you've installed in your windows. 
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.LayoutName.ToLower() == "Tamil (India)")
                    return lang;
            }
            return null;
        }

        public void ChangeLan()
        {
            InputLanguage lang = GetTamilLang();
            if (lang == null)
                Console.Write("Tamil Language keyboard is not installed.");
            //Set the current language of the system to 
            //the InputLanguage instance you need. 
            InputLanguage.CurrentInputLanguage = lang;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void outputpath_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                outpath = open.FileName;
                outputPath_textbox.Text = outpath;
                Console.WriteLine("Output Path: " + outpath);
            }
        }

        private void tesspath_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                tesspath = open.FileName;
                tesspath_textbox.Text = tesspath;
                Console.WriteLine("Tessaract Path: " + tesspath);
            }
        }
    }
}

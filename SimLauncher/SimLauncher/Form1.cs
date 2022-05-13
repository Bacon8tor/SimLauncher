using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System.Diagnostics;
using System.IO;
using IWshRuntimeLibrary;


namespace SimLauncher
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        int numPrgms = 1;

        List<string> prgmList = new List<string>();

        MetroColorStyle colorStyle = Properties.Settings.Default.style;
        MetroThemeStyle themeStyle = Properties.Settings.Default.theme;

        Bitmap uploadImage;

        public Form1()
        {
            InitializeComponent();
            this.StyleManager = msm;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            appyThemeAndStyle();
        }

        private void appyThemeAndStyle()
        {
            msm.Theme = themeStyle;
            msm.Style = colorStyle;
            fillThemeandStyles();
        }

        private void fillThemeandStyles()
        {
            foreach (MetroColorStyle c in (MetroColorStyle[])Enum.GetValues(typeof(MetroColorStyle)))
            {
                styleBox.Items.Add(c.ToString());

            }

            foreach (MetroThemeStyle c in (MetroThemeStyle[])Enum.GetValues(typeof(MetroThemeStyle)))
            {
                themeBox.Items.Add(c.ToString());
            }
        }

        private void themeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (themeBox.SelectedIndex)
            {

                case 0:
                    msm.Theme = MetroThemeStyle.Light;
                    break;
                case 1:
                    msm.Theme = MetroThemeStyle.Dark;
                    break;
                default:
                    msm.Theme = MetroThemeStyle.Default;
                    break;
            }
            Properties.Settings.Default.theme = msm.Theme;
        }

        private void styleBox_SelectedValueChanged(object sender, EventArgs e)
        {

            msm.Style = (MetroColorStyle)styleBox.SelectedIndex;
            Properties.Settings.Default.style = msm.Style;
        }

        private void addPrgm(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose Program...";
            ofd.InitialDirectory = @"c:\";
            ofd.Filter = "Exe Files (*.EXE)|*.exe|All files (*.exe)|*.exe";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MetroLabel lb = new MetroLabel();
                lb.AutoSize = true;
                lb.Text = $"{numPrgms}. {ofd.FileName}";
                lb.Size = new System.Drawing.Size(550, 25);
                lb.Name = $"prgm_{numPrgms}";
                lb.Style = msm.Style;
                lb.Theme = msm.Theme;

                prgmList.Add($"{ofd.FileName}");
                prgmPanel.Controls.Add(lb);
            }
            numPrgms++;
        }



        private void Form1_FormClosing(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            MetroLabel textLabel = new MetroLabel() { Left = 50, Top = 20, Text = text, AutoSize = true };
            MetroTextBox textBox = new MetroTextBox() { Left = 50, Top = 50, Width = 400 };
            MetroButton confirmation = new MetroButton() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void addPrgmDelay(object sender, EventArgs e)
        {
            string delayLength = ShowDialog("Enter in milli-seconds how long you want the delay", "Delay");

                MetroLabel lb = new MetroLabel();
                lb.AutoSize = true;
                lb.Text = $"{numPrgms}. Delay for {delayLength} ms";
                lb.Size = new System.Drawing.Size(550, 25);
                lb.Name = $"prgm_{numPrgms}";
                lb.Style = msm.Style;
                lb.Theme = msm.Theme;

                prgmList.Add($"SLEEP {delayLength}");
                prgmPanel.Controls.Add(lb);

            numPrgms++;
        }

        private void createShortcut_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists($"{programNameTextBox.Text}.bat")) // If file does not exists
            {
                System.IO.File.Create($"{programNameTextBox.Text}.bat").Close(); // Create file
                using (StreamWriter sw = System.IO.File.AppendText($"{programNameTextBox.Text}.bat"))
                {
                    sw.WriteLine("@echo off");
                    foreach (var s in prgmList)
                    {
                        if (s.Contains("SLEEP"))
                        {
                            sw.WriteLine(s); // Write text to .txt file
                        }else
                        {
                            sw.WriteLine($"start \"\" \"{s}\"");
                        }
                        
                    }
                }
                string path = Path.Combine(Environment.CurrentDirectory, $"{programNameTextBox.Text}.bat");
                CreateShortcut(programNameTextBox.Text, Environment.GetFolderPath(Environment.SpecialFolder.Desktop), path);
            }
        }

        public static void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation)
        {
            string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = "SimLauncher Shortcut";   // The description of the shortcut

            shortcut.IconLocation = @"D:\temp\test.ico";           // The icon of the shortcut
            shortcut.TargetPath = targetFileLocation;                 // The path of the file that will launch when the shortcut is run
            shortcut.Save();                                    // Save the shortcut
        }

        private void addWebPage_Click(object sender, EventArgs e)
        {
            string s = ShowDialog("Enter Webpage", "Webpage");
            MetroLabel lb = new MetroLabel();
            lb.AutoSize = true;
            lb.Text = $"{numPrgms}. Launch webpage {s}";
            lb.Size = new System.Drawing.Size(550, 25);
            lb.Name = $"prgm_{numPrgms}";
            lb.Style = msm.Style;
            lb.Theme = msm.Theme;

            if (!s.Contains("http")) { prgmList.Add($"http://{s}"); }
            else { prgmList.Add($"{s}"); }
            prgmPanel.Controls.Add(lb);

            numPrgms++;

        }

        private void imgConvert(Bitmap bmap)
        {
            using (FileStream FS = System.IO.File.OpenWrite(@"D:\temp\test.ico"))
            {
                Bitmap bitmap = bmap;
                Icon.FromHandle(bitmap.GetHicon()).Save(FS);
            }
        }

        private void iconAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose Img...";
            ofd.InitialDirectory = @"c:\";
            ofd.Filter = "Png Files (*.PNG)|*.png|All files (*.png)|*.png";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgConvert((Bitmap)Image.FromFile(ofd.FileName));
            }
            //imgConvert(uploadImage);
        }
    }
}

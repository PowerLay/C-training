using System;
using System.IO;
using System.Windows.Forms;

namespace ViewFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            locationTextBox.Text = ofd.FileName;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                TextReader tr = new StreamReader(locationTextBox.Text);
                try
                {
                    displayTextBox.Text = tr.ReadToEnd();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tr.Close();
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Sorry, the file does not exist.");
            }
            catch (System.UnauthorizedAccessException)
            {
                MessageBox.Show("Sorry, you lack sufficient privileges.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
namespace PrebuiltDesigns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open a file";
            ofd.Filter = "TEXT file/*.text/RTF file/*.rtf";
            //ofd.ShowDialog();

            if (ofd.ShowDialog() == DialogResult.OK) ;
            {
                //MessageBox.Show("clicked open button");

                //MessageBox.Show(ofd.FileName);

                //MessageBox.Show(ofd.SafeFileName);

                //read from txt file.
                string filePath = ofd.FileName;
                //txtFileContent.Text = fileContent;

                //read from rtf file
                rtxFileContent.LoadFile(filePath);
            }
        }

        // this show btnOpenFile_Click in above section, should not create another function of this name, change name under openFile in properties.
        private void btnOpenFile_Click(object sender, EventArgs e)
        {

        }
        // Save File
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save a file";
            sfd.Filter = "TEXT file/*.text/RTF file/*.rtf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;
                //SAVE TO TXT FILE
                File.WriteAllText(filePath, txtFileContent.Text);

                rtxFileContent.SaveFile(filePath);
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtFileContent.Font = fd.Font;
                txtFileContent.ForeColor = fd.Color; // Back color refer to background color and fore color refer to text color

                rtxFileContent.Font = fd.Font;
                rtxFileContent.ForeColor = fd.Color;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //rtxFileContent.Font = fd.Font;
            //rtxFileContent.ForeColor = fd.Color;
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}
    }
}

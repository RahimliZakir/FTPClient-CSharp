using FluentFTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPClient.WindowsFormsApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        /*
        FTP URL: ftp.dlptest.com or ftp://ftp.dlptest.com/
        FTP User: dlpuser
        Password: rNrKYTX9g7z3RgJRmxWuGHbeu
        */

        string firstDirectory = @"data\files";

        string secondWorkingDirectory = @"WorkingDirectory";
        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            using (var client = new FtpClient("ftp.dlptest.com", 21, user: "dlpuser", pass: "rNrKYTX9g7z3RgJRmxWuGHbeu"))
            {

                labelStatus.Text = "Connecting";

                client.Connect();

                labelStatus.Text = "Connected";

                labelStatus.Text = "Setting Current Directory";

                Directory.SetCurrentDirectory(firstDirectory);

                labelStatus.Text = "Current Directory has been set.";

                labelStatus.Text = "Uploading Files";

                client.UploadFile(@"firstfile.txt", "firstfile.txt");

                labelStatus.Text = "Fies have been uploaded.";

                labelStatus.Text = "Disconnecting.";

                client.Disconnect();

                labelStatus.Text = "Disconnected.";

                MessageBox.Show("File'ların FTP Serverə göndərilməsi uğurla başa çatmışdır.", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCreateFolderAndUploadFile_Click(object sender, EventArgs e)
        {
            using (var client = new FtpClient("ftp.dlptest.com", 21, user: "dlpuser", pass: "rNrKYTX9g7z3RgJRmxWuGHbeu"))
            {

                labelStatus.Text = "Connecting";

                client.Connect();

                labelStatus.Text = "Connected";

                labelStatus.Text = "Checking Working Directory Exist.";

                bool result = client.DirectoryExists(secondWorkingDirectory);

                if (result == false)
                {
                    labelStatus.Text = "Creating Directory.";

                    labelStatus.Text = "Creating Working Directory.";

                    client.CreateDirectory(secondWorkingDirectory);

                    labelStatus.Text = "Working Directory has been created.";
                }

                labelStatus.Text = "Setting Working Directory";

                client.SetWorkingDirectory(secondWorkingDirectory);

                labelStatus.Text = "Working Directory has been set.";

                labelStatus.Text = "Uploading Files";

                client.UploadFile(@"firstfile.txt", "firstfile.txt");

                labelStatus.Text = "Fies have been uploaded.";

                labelStatus.Text = "Disconnecting.";

                client.Disconnect();

                labelStatus.Text = "Disconnected.";

                MessageBox.Show("File'ların FTP Serverə göndərilməsi uğurla başa çatmışdır.", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGetLising_Click(object sender, EventArgs e)
        {
            using (var client = new FtpClient("ftp.dlptest.com", 21, user: "dlpuser", pass: "rNrKYTX9g7z3RgJRmxWuGHbeu"))
            {
                client.Connect();

                client.SetWorkingDirectory(secondWorkingDirectory);

                client.UploadFile(@"thirdfile.txt", "thirdfile.txt");

                Listing(client);

                client.Disconnect();
            }
        }

        private void Listing(FtpClient client)
        {
            FtpListItem[] listing = client.GetListing();

            listBox1.Items.Clear();

            foreach (FtpListItem listItem in listing)
            {
                listBox1.Items.Add(listItem.FullName);
            }
        }
    }
}

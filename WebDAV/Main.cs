using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebDAV
{
    public partial class Main : Form
    {

        string host;
        string login;
        string password;
        string info;

        string clientPath;

        const int bufferLength = 8000;

        public Main()
        {

            InitializeComponent();

            editHost.Text = "https://webdav.yandex.ru/";

        }

        private void actionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            panel.Enabled = true;

            labelInfo.Visible = true;
            editInfo.Visible = true;

            switch (cbAction.SelectedIndex)
            {

                case 0:
                    labelInfo.Text = "Collection Path:";
                    break;

                case 1:
                    labelInfo.Text = "File/Collection Path:";
                    break;

                case 2:
                    labelInfo.Text = "File's Path On Server";

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        clientPath = saveFileDialog.FileName;
                    }
                    saveFileDialog.Dispose();

                    break;

                case 3:
                    labelInfo.Text = "File's Path On Server";

                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        clientPath = openFileDialog.FileName;
                    }
                    openFileDialog.Dispose();

                    break;

            }

        }

        private void pbOK_Click(object sender, EventArgs e)
        {

            host = editHost.Text;
            login = editLogin.Text;
            password = editPassword.Text;
            info = editInfo.Text;

            host += info;
            host = host.TrimEnd();

            switch (cbAction.SelectedIndex)
            {

                case 0:
                    MakeCollection();
                    break;

                case 1:
                    Delete();
                    break;

                case 2:
                    DownloadFile();
                    break;

                case 3:
                    UploadFile();
                    break;

            }
        }

        private void MakeCollection()
        {
            try
            {

                HttpWebRequest request = HttpWebRequest.Create(host) as HttpWebRequest;
                request.Credentials = new NetworkCredential(login, password);
                request.Method = WebRequestMethods.Http.MkCol;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                HttpStatusCode code = response.StatusCode;

                if (code == HttpStatusCode.Created)
                {
                    MessageBox.Show("The collection was created.");
                }
                else
                {
                    MessageBox.Show("Something got wrong. Please, try again later.");
                }

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);   
            }
        }

        private void Delete()
        {
            try
            {

                HttpWebRequest request = HttpWebRequest.Create(host) as HttpWebRequest;
                request.Credentials = new NetworkCredential(login, password);
                request.Method = "DELETE";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                HttpStatusCode code = response.StatusCode;

                if (code == HttpStatusCode.NoContent)
                {
                    MessageBox.Show("The file/collection was deleted.");
                }
                else
                {
                    MessageBox.Show("Something got wrong. Please, try again later.");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DownloadFile()
        {
            try
            {

                HttpWebRequest request = HttpWebRequest.Create(host) as HttpWebRequest;
                request.Credentials = new NetworkCredential(login, password);
                request.Method = "GET";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                HttpStatusCode code = response.StatusCode;

                byte[] buffer = new byte[bufferLength];
                int bytesRead = 0;
                long totalBytesRead = 0;

                FileStream fileStream = new FileStream(clientPath, FileMode.Create, FileAccess.Write);
                Stream responseStream = response.GetResponseStream();

                do
                {

                    bytesRead = responseStream.Read(buffer, 0, bufferLength);
                    if (bytesRead > 0)
                    {
                        totalBytesRead += bytesRead;
                        fileStream.Write(buffer, 0, bytesRead);
                    }

                }
                while (bytesRead > 0);

                fileStream.Close();
                responseStream.Close();

                long contentLength = long.Parse(response.GetResponseHeader("Content-Length"));
                if (totalBytesRead == response.ContentLength)
                {
                    MessageBox.Show("The file was downloaded succesfully.");
                }
                else
                {
                    MessageBox.Show("Something got wrong. Please, try again later.");
                }         
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UploadFile()
        {
            try
            {

                HttpWebRequest request = HttpWebRequest.Create(host) as HttpWebRequest;
                request.Credentials = new NetworkCredential(login, password);
                request.Method = "PUT";
                FileInfo fileInfo = new FileInfo(clientPath);
                request.ContentLength = fileInfo.Length;
                request.KeepAlive = false;
                request.ReadWriteTimeout = -1;
                request.Timeout = -1;
                request.AllowWriteStreamBuffering = false;
                request.PreAuthenticate = true;
                request.SendChunked = false;
                request.ContentType = "application/binary";
                request.ProtocolVersion = HttpVersion.Version11;
                request.ServicePoint.ConnectionLimit = 1;
                request.AllowAutoRedirect = false;
                request.ServicePoint.Expect100Continue = true;
                request.Accept = "*/*";

                byte[] buffer = new byte[bufferLength];
                int bytesRead = 0;
                long totalBytesRead = 0;

                FileStream fileStream = new FileStream(clientPath, FileMode.Open, FileAccess.Read);
                Stream requestStream = request.GetRequestStream();

                do
                {

                    bytesRead = fileStream.Read(buffer, 0, bufferLength);
                    if (bytesRead > 0)
                    {
                        totalBytesRead += bytesRead;
                        requestStream.Write(buffer, 0, bytesRead);
                    }

                }
                while (bytesRead > 0);

                fileStream.Close();
                requestStream.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                HttpStatusCode code = response.StatusCode;

                if (code == HttpStatusCode.Created && totalBytesRead == request.ContentLength)
                {
                    MessageBox.Show("The file was uploaded succesfully.");
                }
                else
                {
                    MessageBox.Show("Something got wrong. Please, try again later.");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

using AndroidDebugOverpass.Command;
using AndroidDebugOverpass.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace AndroidDebugOverpass
{
    public partial class MainForm : Form
    {
        private BindingList<Device> mDevices = new BindingList<Device>();

        public MainForm()
        {
            InitializeComponent();
            lstDevices.DataSource = mDevices;
            RefreshDevices();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDevices();
        }

        private void RefreshDevices()
        {
            Devices devices = new Devices();
            devices.Execute(
                d => {
                    UdpateDeviceList(d);
                },
                exception => { MessageBox.Show(exception.Message); });
        }

        private void UdpateDeviceList(List<Device> devices)
        {
            mDevices.Clear();
            foreach (Device device in devices)
            {
                mDevices.Add(device);
            }
        }

        private void txtApkPath_DragDrop(object sender, DragEventArgs e)
        {
            DataObject data = (DataObject) e.Data;
            if (data.ContainsFileDropList())
            {
                string[] rawFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
                List<string> paths = new List<string>(rawFiles.Length);
                if (rawFiles != null)
                {
                    foreach (string path in rawFiles)
                    {
                        if (path.EndsWith(".apk", true, null))
                        {
                            paths.Add(path);
                        }
                    }
                }

                txtApkPath.Text = paths[0];
            }
           
        }

        private void InstallApk(string path)
        {
            Install install = new Install();
            install.ForApk(path).ForDevice(lstDevices.SelectedItem as Device).Execute(success => { }, exceptoin => { });
        }

        private void txtApkPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
           
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            InstallApk(txtApkPath.Text);
        }
    }
}

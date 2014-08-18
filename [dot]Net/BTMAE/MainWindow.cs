using System;
using System.Windows.Forms;

using BTMAE.Properties;

using InTheHand.Net.Sockets;

namespace BTMAE
{
    public partial class MainMindow : Form
    {
        public MainMindow()
        {
            InitializeComponent();

            pendingSearch = false;
            poking = false;

            //read configuration and localization data
            System.Xml.XmlDocument config = new System.Xml.XmlDocument();
            
            try
            {
                //the xml file is stored in the data directory of the application
                config.Load(System.Deployment.Application.ApplicationDeployment.CurrentDeployment.DataDirectory + @"\config.xml");
                notificaion.BalloonTipTitle = config.GetElementsByTagName("header")[0].InnerText; ;
                aboutTB.Text = config.GetElementsByTagName("about")[0].InnerText;

                //start the bluetooth client
                client = new BluetoothClient();
                //bluetooth device is enabled
                enabled = true;
                //noify user that program is ready to explor
                notificaion.BalloonTipText = "ready!";
                notificaion.BalloonTipIcon = ToolTipIcon.Info;
            }
            catch (System.IO.FileNotFoundException)
            {
                //TODO: exception
            }
            catch (NotSupportedException)
            {
                //no bluetooth device was found on the host machine
                enabled = false;
                notificaion.BalloonTipText = config.GetElementsByTagName("error")[0].InnerText;
                notificaion.BalloonTipIcon = ToolTipIcon.Error;
            }
        }

        /// <summary>
        /// Explor button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void explor_Click(object sender, System.EventArgs e)
        {
            if (!pendingSearch)
            {
                pendingSearch = true;

                //start search
                System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(Explore));
                thread.Start();
            }
            else
            {
                MessageBox.Show("already exploring! please wait...");
            }
        }

        /// <summary>
        /// Get the full list of bluetooth devices around the area
        /// </summary>
        private void Explore()
        {
            //noify user that program is exploring
            notificaion.BalloonTipText = "exploring...";
            //show noificaion
            notificaion.ShowBalloonTip(2000);
            
            try
            {
                //search for bluetooth devices
                devices = client.DiscoverDevices();
                //build the list of found devices
                deviceList = new System.Collections.Generic.List<string>();

                foreach (BluetoothDeviceInfo device in devices)
                {
                    deviceList.Add(device.DeviceName);
                }

                //update the GUI list of devices
                devicesComboBox.DataSource = deviceList;

                //noify user that program is exploring
                notificaion.BalloonTipText = "done!";
                //show noificaion
                notificaion.ShowBalloonTip(500);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                pendingSearch = false;
            }
        }

        /// <summary>
        /// devices combobox selecion change event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void devicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (devicesComboBox.SelectedIndex != -1)
            {
                BluetoothDeviceInfo device = (BluetoothDeviceInfo)devices.GetValue(devicesComboBox.SelectedIndex);

                //display device properties on GUI
                macAddressTextBox.Text = device.DeviceAddress.ToString();
                nameTextBox.Text = device.DeviceName;
                connectedTB.Text = (device.Connected) ? Properties.Resources.TRUE : Properties.Resources.FALSE;
                authenticatedTB.Text = (device.Authenticated) ? Properties.Resources.TRUE : Properties.Resources.FALSE;
                rememberedTB.Text = (device.Remembered) ? Properties.Resources.TRUE : Properties.Resources.FALSE;
                lastSeenTB.Text = device.LastSeen.ToString();
                lastUsedTB.Text = device.LastUsed.ToString();
            }
        }

        /// <summary>
        /// window loaded event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMindow_Load(object sender, EventArgs e)
        {
            //disable button if machine is not equipped with bluetooth device
            explor.Enabled = enabled;
            //show noificaion
            notificaion.ShowBalloonTip(2000);
        }

        /// <summary>
        /// Mac address label click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //lunch wikipedia article about mac address
            System.Diagnostics.Process.Start(Properties.Resources.WikiPedia);
        }

        private void aboutTB_Click(object sender, EventArgs e)
        {
            //lunch the 32feet.net library website
            System.Diagnostics.Process.Start(Properties.Resources.Feet32);
        }

        private void poke_Click(object sender, EventArgs e)
        {
            if (devicesComboBox.SelectedIndex != -1)
            {
                //get the selected bluetooth device selected
                BluetoothDeviceInfo device = (BluetoothDeviceInfo)devices.GetValue(devicesComboBox.SelectedIndex);

                if (!poking)
                {
                    if (!string.IsNullOrEmpty(pokeBox.Text))
                    {
                        poking = true;

                        //build the method argument
                        object args = new object[2] {device.DeviceAddress, pokeBox.Text};
                        //start poke
                        System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(Poke));
                        thread.Start(args);
                    }
                    else
                    {
                        MessageBox.Show("Please supply in the poke string in the text field on the right of poke button");
                    }
                }
                else
                {
                    MessageBox.Show("currenly poking a device! please wait...");
                }
            }
        }

        /// <summary>
        /// Send a poke message to the bluetooth device.
        /// </summary>
        void Poke(object parameters)
        {
            Array argsArray = (Array)parameters;

            InTheHand.Net.BluetoothAddress address = argsArray.GetValue(0) as InTheHand.Net.BluetoothAddress;

            //noify user that program is exploring
            notificaion.BalloonTipText = "poking: " + address.ToString();
            //show noificaion
            notificaion.ShowBalloonTip(2000);

            try
            {
                //connect to the choosen device
                client.Connect(address, InTheHand.Net.Bluetooth.BluetoothService.SerialPort);
                //get the associated nework stream
                System.Net.Sockets.NetworkStream stream = client.GetStream();

                //send a poke message
                byte[] buffer = System.Text.Encoding.ASCII.GetBytes((string)argsArray.GetValue(1));
                stream.Write(buffer, 0, buffer.Length);

                //noify user that program is exploring
                notificaion.BalloonTipText = "done!";
                //show noificaion
                notificaion.ShowBalloonTip(500);
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                MessageBox.Show(ex.Message, "Error poking: " + address.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                poking = false;
            }
        }

        /// <summary>
        /// client of a bluetooth chip that looks for devices
        /// </summary>
        private BluetoothClient client;

        /// <summary>
        /// devices found
        /// </summary>
        private BluetoothDeviceInfo[] devices;

        /// <summary>
        /// list of devices found
        /// </summary>
        private System.Collections.Generic.List<string> deviceList;

        /// <summary>
        /// Indicates wether a current explor operaion is being executed or not
        /// </summary>
        private bool pendingSearch;

        /// <summary>
        /// Indicates if the host machine has a bluetooth device or it is not supported
        /// </summary>
        private bool enabled;

        /// <summary>
        /// Indicates a device being poked at the moment
        /// </summary>
        private bool poking;

    }
}

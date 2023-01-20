using System;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace BARMAN_STORE1._0
{
    public partial class ScannerForm : Form
    {
        #region 1 Declaration of Controls




        #endregion
        public ScannerForm()
        {
            InitializeComponent();
            image = null;
        }


        private string imageExtension = "";
        private ImageFile image = new ImageFile();

        
        private void Form2_Load(object sender, EventArgs e)
        {
            ListScanners();

            // Set start output folder TMP
            textFolder.Text = Path.GetTempPath();
            // Set JPEG as default
            comboBox1.SelectedIndex = 1;

        }

        private void ListScanners()
        {
            // Clear the ListBox.
            listBox1.Items.Clear();

            // Create a DeviceManager instance
            var deviceManager = new DeviceManager();

            // Loop through the list of devices and add the name to the listbox
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // Add the device only if it's a scanner
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                // Add the Scanner device to the listbox (the entire DeviceInfos object)
                // Important: we store an object of type scanner (which ToString method returns the name of the scanner)
                listBox1.Items.Add(
                    new Scanner(deviceManager.DeviceInfos[i])
                );
            }
            listBox1.Items.Add("");
            listBox1.Items.Add("End of List");
        }
        #region Scan Function
        private void scanButton_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(StartScanning).ContinueWith(result => TriggerScan());
            
        }

        private void TriggerScan()
        {
            Console.WriteLine("Image succesfully scanned");
        }

        public void StartScanning()
        {
            int scanResolutionDPI = int.Parse(textResolution.Text);
            int scanStartLeftPixel = 0;
            int scanStartTopPixel = 0;
            int scanWidthPixel = int.Parse(textWidth.Text);
            int scanHeightPixels = int.Parse(textHeight.Text);
            int brightnessPercents = int.Parse(textBrightness.Text);
            int contrastPercents = int.Parse(textContrast.Text);
            int colorMode = int.Parse(textColorMode.Text);
            Scanner device = null;
            this.Invoke(new MethodInvoker(delegate ()
            {
                device = listBox1.SelectedItem as Scanner;
            }));

            if (device == null)
            {
                MessageBox.Show("You need to select first an scanner device from the list",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (String.IsNullOrEmpty(textFileName.Text))
            {
                MessageBox.Show("Provide a filename",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //ImageFile image = new ImageFile();


            this.Invoke(new MethodInvoker(delegate ()
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        image = device.Scan(WIA.FormatID.wiaFormatPNG, scanResolutionDPI, scanStartLeftPixel, scanStartTopPixel, scanWidthPixel, scanHeightPixels, brightnessPercents, contrastPercents, colorMode);
                        imageExtension = ".png";
                        break;
                    case 1:
                        image = device.Scan(WIA.FormatID.wiaFormatJPEG, scanResolutionDPI, scanStartLeftPixel, scanStartTopPixel, scanWidthPixel, scanHeightPixels, brightnessPercents, contrastPercents, colorMode);
                        imageExtension = ".jpeg";
                        break;
                    case 2:
                        image = device.Scan(WIA.FormatID.wiaFormatTIFF, scanResolutionDPI, scanStartLeftPixel, scanStartTopPixel, scanWidthPixel, scanHeightPixels, brightnessPercents, contrastPercents, colorMode);
                        imageExtension = ".tiff";
                        break;
                    case 3:
                        image = device.Scan(WIA.FormatID.wiaFormatBMP, scanResolutionDPI, scanStartLeftPixel, scanStartTopPixel, scanWidthPixel, scanHeightPixels, brightnessPercents, contrastPercents, colorMode);
                        imageExtension = ".bmp";
                        break;
                    case 4:
                        image = device.Scan(WIA.FormatID.wiaFormatGIF, scanResolutionDPI, scanStartLeftPixel, scanStartTopPixel, scanWidthPixel, scanHeightPixels, brightnessPercents, contrastPercents, colorMode);
                        imageExtension = ".gif";
                        break;
                }

            }));


            var imageBytes = (byte[])image.FileData.get_BinaryData();
            var ms = new MemoryStream(imageBytes);
            var img = System.Drawing.Image.FromStream(ms);
            pictureBox1.Image = img;
        }
        #endregion
        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                textFolder.Text = folderDlg.SelectedPath;
            }
        }
        #region Save Button Function
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (image != null) Task.Factory.StartNew(StartSaving).ContinueWith(result => TriggerSave());
            else MessageBox.Show("Nothing to save");
        }

        private bool StartSaving()
        {
            var path = textFolder.Text + "\\" + textFileName.Text + imageExtension;
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                image.SaveFile(path);
                return true;
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                //Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void TriggerSave()
        {
            MessageBox.Show("File Saved");

        }
        #endregion
        private void textResolution_Validating(object sender, CancelEventArgs e)
        {
            int v = 300;
            if (string.IsNullOrEmpty(textResolution.Text) || int.TryParse(textResolution.Text, out v) == false) { textResolution.Text = 300 + ""; }

            int value = int.Parse(textResolution.Text);


            if (value < 50 || value > 600)
            {
                value = 300;
                textResolution.Text = value + "";
            }
            textWidth.Text = "" + (value * 8);
            textHeight.Text = "" + (value * 11);
        }

        private void textWidth_Validating(object sender, CancelEventArgs e)
        {
            int value = 300;
            if (string.IsNullOrEmpty(textWidth.Text) || int.TryParse(textWidth.Text, out value) == false) { textWidth.Text = 0 + ""; }

            value = int.Parse(textWidth.Text);
            int resolution = int.Parse(textResolution.Text);
            if (value <= 0 || value > resolution * 8)
            {
                value = resolution * 8;
                textWidth.Text = value + "";
            }
        }

        private void textHeight_Validating(object sender, CancelEventArgs e)
        {
            int v = 300;
            if (string.IsNullOrEmpty(textHeight.Text) || int.TryParse(textHeight.Text, out v) == false) { textHeight.Text = 0 + ""; }

            int value = int.Parse(textHeight.Text);
            int resolution = int.Parse(textResolution.Text);
            if (value <= 0 || value > (int)resolution * 11)
            {
                value = (int)(resolution * 11);
                textHeight.Text = value + "";
            }
        }

        private void textBrightness_Validating(object sender, CancelEventArgs e)
        {
            int v = 300;
            if (string.IsNullOrEmpty(textBrightness.Text) || int.TryParse(textBrightness.Text, out v) == false) { textBrightness.Text = 0 + ""; }

            int value = int.Parse(textBrightness.Text);
            if (value < 0 || value > 100)
            {
                value = 0;
                textBrightness.Text = value + "";
            }
        }

        private void textContrast_Validating(object sender, CancelEventArgs e)
        {
            int v = 300;
            if (string.IsNullOrEmpty(textContrast.Text) || int.TryParse(textContrast.Text, out v) == false) { textContrast.Text = 0 + ""; }

            int value = int.Parse(textContrast.Text);
            if (value < 0 || value > 100)
            {
                value = 0;
                textContrast.Text = value + "";
            }
        }

        private void textColorMode_Validating(object sender, CancelEventArgs e)
        {
            int v = 300;
            if (string.IsNullOrEmpty(textColorMode.Text) || int.TryParse(textColorMode.Text, out v) == false) { textColorMode.Text = 0 + ""; }

            int value = int.Parse(textColorMode.Text);
            if (value < 0 || value > 100)
            {
                value = 0;
                textColorMode.Text = value + "";
            }
        }

        public System.Drawing.Image ReturnImage()
        {
            System.Drawing.Image img = null;
            if (image != null)
            {
                var imageBytes = (byte[])image.FileData.get_BinaryData();
                var ms = new MemoryStream(imageBytes);
                img = System.Drawing.Image.FromStream(ms);
            }
            return img;
        }

    }


    class Scanner
    {
        CommonDialogClass dlg = new CommonDialogClass();
        private readonly DeviceInfo _deviceInfo;


        public Scanner(DeviceInfo deviceInfo)
        {
            this._deviceInfo = deviceInfo;
        }




        /// <summary>
        /// Adjusts the settings of the scanner with the providen parameters.
        /// </summary>
        /// <param name="scannnerItem">Expects a </param>
        /// <param name="scanResolutionDPI">Provide the DPI resolution that should be used e.g 150</param>
        /// <param name="scanStartLeftPixel"></param>
        /// <param name="scanStartTopPixel"></param>
        /// <param name="scanWidthPixels"></param>
        /// <param name="scanHeightPixels"></param>
        /// <param name="brightnessPercents"></param>
        /// <param name="contrastPercents">Modify the contrast percent</param>
        /// <param name="colorMode">Set the color mode</param>
        private static void AdjustScannerSettings(IItem scannnerItem, int scanResolutionDPI, int scanStartLeftPixel, int scanStartTopPixel, int scanWidthPixels, int scanHeightPixels, int brightnessPercents, int contrastPercents, int colorMode)
        {
            const string WIA_SCAN_COLOR_MODE = "6146";
            const string WIA_HORIZONTAL_SCAN_RESOLUTION_DPI = "6147";
            const string WIA_VERTICAL_SCAN_RESOLUTION_DPI = "6148";
            const string WIA_HORIZONTAL_SCAN_START_PIXEL = "6149";
            const string WIA_VERTICAL_SCAN_START_PIXEL = "6150";
            const string WIA_HORIZONTAL_SCAN_SIZE_PIXELS = "6151";
            const string WIA_VERTICAL_SCAN_SIZE_PIXELS = "6152";
            const string WIA_SCAN_BRIGHTNESS_PERCENTS = "6154";
            const string WIA_SCAN_CONTRAST_PERCENTS = "6155";
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_START_PIXEL, scanStartLeftPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_START_PIXEL, scanStartTopPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_SIZE_PIXELS, scanWidthPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_SIZE_PIXELS, scanHeightPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_BRIGHTNESS_PERCENTS, brightnessPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_CONTRAST_PERCENTS, contrastPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_COLOR_MODE, colorMode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="propName"></param>
        /// <param name="propValue"></param>
        private static void SetWIAProperty(IProperties properties, object propName, object propValue)
        {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }

        /// <summary>
        /// Declare the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (string)this._deviceInfo.Properties["Name"].get_Value();
        }



        public ImageFile Scan(string format, int scanResolutionDPI, int scanStartLeftPixel, int scanStartTopPixel, int scanWidthPixel, int scanHeightPixels, int brightnessPercents, int contrastPercents, int colorMode)
        {
            // Connect to the device and instruct it to scan
            // Connect to the device
            var device = this._deviceInfo.Connect();

            // Select the scanner
            //CommonDialogClass dlg = new CommonDialogClass();

            var item = device.Items[1];

            try
            {
                AdjustScannerSettings(item, scanResolutionDPI, scanStartLeftPixel, scanStartTopPixel, scanWidthPixel, scanHeightPixels, brightnessPercents, contrastPercents, colorMode);

                object scanResult = dlg.ShowTransfer(item, format, true);

                if (scanResult != null)
                {
                    var imageFile = (ImageFile)scanResult;

                    // Return the imageFile
                    return imageFile;
                }
            }
            catch (COMException e)
            {
                // Display the exception in the console.
                Console.WriteLine(e.ToString());

                uint errorCode = (uint)e.ErrorCode;

                // Catch 2 of the most common exceptions
                if (errorCode == 0x80210006)
                {
                    MessageBox.Show("The scanner is busy or isn't ready");
                }
                else if (errorCode == 0x80210064)
                {
                    MessageBox.Show("The scanning process has been cancelled.");
                }
                else
                {
                    MessageBox.Show("A non catched error occurred, check the console", "Error", MessageBoxButtons.OK);
                }
            }

            return new ImageFile();
        }
    }
}
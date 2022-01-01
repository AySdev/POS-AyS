using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.IO;
using System.Windows.Forms;


namespace POS_AyS
{
    public class clsCaracteristicas
    {
        frmAcerca acerca = new frmAcerca();
        public void video()

        {
            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");

            foreach (ManagementObject obj in myVideoObject.Get())
            {
                acerca.txtInfoVid.Text += ("Name  -  " + obj["Name"]) + Environment.NewLine;
                acerca.txtInfoVid.Text += ("Name  -  " + obj["Name"]) + Environment.NewLine;
                acerca.txtInfoVid.Text += ("Status  -  " + obj["Status"] + Environment.NewLine);
                acerca.txtInfoVid.Text += ("Caption  -  " + obj["Caption"] + Environment.NewLine);
                acerca.txtInfoVid.Text += ("DeviceID  -  " + obj["DeviceID"] + Environment.NewLine);
                acerca.txtInfoVid.Text += ("AdapterRAM  -  " + obj["AdapterRAM"] + Environment.NewLine);
                acerca.txtInfoVid.Text += ("AdapterDACType  -  " + obj["AdapterDACType"]) + Environment.NewLine;
                acerca.txtInfoVid.Text += ("Monochrome  -  " + obj["Monochrome"] + Environment.NewLine);
                acerca.txtInfoVid.Text += ("InstalledDisplayDrivers  -  " + obj["InstalledDisplayDrivers"] + Environment.NewLine);
                acerca.txtInfoVid.Text += ("DriverVersion  -  " + obj["DriverVersion"] + Environment.NewLine);
                acerca.txtInfoVid.Text += ("VideoProcessor  -  " + obj["VideoProcessor"] + Environment.NewLine);
                acerca.txtInfoVid.Text += ("VideoArchitecture  -  " + obj["VideoArchitecture"] + Environment.NewLine);
                acerca.txtInfoVid.Text += ("VideoMemoryType  -  " + obj["VideoMemoryType"] + Environment.NewLine);
            }
        }

        public void os()
        {
            ManagementObjectSearcher myOperativeSystemObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
            string a = ("");
            foreach (ManagementObject obj in myOperativeSystemObject.Get())
            {
                a += ("Caption  -  " + obj["Caption"] + Environment.NewLine);
                acerca.txtInfoOs.Text += ("WindowsDirectory  -  " + obj["WindowsDirectory"]) + Environment.NewLine;
                acerca.txtInfoOs.Text += ("ProductType  -  " + obj["ProductType"] + Environment.NewLine);
                acerca.txtInfoOs.Text += ("SerialNumber  -  " + obj["SerialNumber"] + Environment.NewLine);
                acerca.txtInfoOs.Text += ("SystemDirectory  -  " + obj["SystemDirectory"] + Environment.NewLine);
                acerca.txtInfoOs.Text += ("CountryCode  -  " + obj["CountryCode"] + Environment.NewLine);
                acerca.txtInfoOs.Text += ("CurrentTimeZone  -  " + obj["CurrentTimeZone"] + Environment.NewLine);
                acerca.txtInfoOs.Text += ("EncryptionLevel  -  " + obj["EncryptionLevel"] + Environment.NewLine);
                acerca.txtInfoOs.Text += ("OSType  -  " + obj["OSType"] + Environment.NewLine);
                acerca.txtInfoOs.Text += ("Version  -  " + obj["Version"] + Environment.NewLine);
            }
        }

        public void cpu()
        {
            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");

            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                acerca.txtInfoCpu.Text += ("Name  -  " + obj["Name"] + Environment.NewLine);
                acerca.txtInfoCpu.Text += ("DeviceID  -  " + obj["DeviceID"] + Environment.NewLine);
                acerca.txtInfoCpu.Text += ("Manufacturer  -  " + obj["Manufacturer"] + Environment.NewLine);
                acerca.txtInfoCpu.Text += ("CurrentClockSpeed  -  " + obj["CurrentClockSpeed"]) + Environment.NewLine;
                acerca.txtInfoCpu.Text += ("Caption  -  " + obj["Caption"] + Environment.NewLine);
                acerca.txtInfoCpu.Text += ("NumberOfCores  -  " + obj["NumberOfCores"] + Environment.NewLine);
                acerca.txtInfoCpu.Text += ("NumberOfEnabledCore  -  " + obj["NumberOfEnabledCore"]);
                acerca.txtInfoCpu.Text += ("NumberOfLogicalProcessors  -  " + obj["NumberOfLogicalProcessors"] + Environment.NewLine);
                acerca.txtInfoCpu.Text += ("Architecture  -  " + obj["Architecture"] + Environment.NewLine);
                acerca.txtInfoCpu.Text += ("Family  -  " + obj["Family"]);
                acerca.txtInfoCpu.Text += ("ProcessorType  -  " + obj["ProcessorType"] + Environment.NewLine);
                acerca.txtInfoCpu.Text += ("Characteristics  -  " + obj["Characteristics"] + Environment.NewLine);
                acerca.txtInfoCpu.Text += ("AddressWidth  -  " + obj["AddressWidth"] + Environment.NewLine);
            }

        }

    }

}

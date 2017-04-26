using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialTest
{
  public partial class Form1 : Form
  {
    private SerialPort _selectedPort;
    private string[] _ports;
    private int[] _bauds = { 9600, 14400, 19200, 28800, 38400, 57600, 115200 };

    delegate void SetTextCallback(string text);

    public Form1()
    {
      InitializeComponent();
      Init();
    }


    // Button presses
    private void onButton_Click(object sender, EventArgs e)
    {
      _selectedPort.WriteLine("ON");

      btnOn.Enabled = false;
      btnOff.Enabled = true;
    }

    private void offButton_Click(object sender, EventArgs e)
    {
      _selectedPort.WriteLine("OFF");

      btnOn.Enabled = true;
      btnOff.Enabled = false;
    }

    private void btnSelect_Click(object sender, EventArgs e)
    {
      _selectedPort = null;

      if (_ports.Length <= 0)
        return;

      try
      {
        _selectedPort = new SerialPort
        {
          BaudRate = GetBaudRate(),
          PortName = _ports[cbSerialPorts.SelectedIndex]
        };

        _selectedPort.Open();
        ToggleOnButton(true);
        ToggleComSelection(false);

        _selectedPort.DataReceived += SerialDataRecieved;
      }
      catch (Exception ex)
      {
        ToggleOnButton(false);
        ToggleComSelection(true);
        MessageBox.Show(ex.Message, ex.GetType().Name);
      }
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      _selectedPort?.Dispose();
      Init();
    }

    private void btnSend_Click(object sender, EventArgs e)
    {
      _selectedPort.WriteLine(tbRawCmd.Text);
    }


    // Internal methods
    private void Init()
    {
      _ports = SerialPort.GetPortNames();
      cbSerialPorts.DataSource = _ports;
      cbBaudRate.DataSource = _bauds;
      ToggleComSelection(true);
    }

    private void ToggleOnButton(bool onBtnState)
    {
      btnOn.Enabled = onBtnState;
      btnOff.Enabled = !onBtnState;
    }

    private void ToggleComSelection(bool enabled)
    {
      cbSerialPorts.Enabled = enabled;
      btnSelectPort.Enabled = enabled;
      cbBaudRate.Enabled = enabled;
      btnReset.Enabled = !enabled;
      tbRawCmd.Enabled = !enabled;
      btnSendCmd.Enabled = !enabled;

      if (!enabled)
        return;

      rtbSerialOut.Clear();
      btnOn.Enabled = false;
      btnOff.Enabled = false;
    }

    private int GetBaudRate()
    {
      var rawValue = cbBaudRate.Text;
      int parsed;
      return int.TryParse(rawValue, out parsed) ? parsed : 0;
    }

    private void SetText(string text)
    {
      // InvokeRequired required compares the thread ID of the
      // calling thread to the thread ID of the creating thread.
      // If these threads are different, it returns true.
      if (this.rtbSerialOut.InvokeRequired)
      {
        SetTextCallback d = new SetTextCallback(SetText);
        this.Invoke(d, new object[] { text });
      }
      else
      {
        this.rtbSerialOut.Text += text;
        rtbSerialOut.SelectionStart = rtbSerialOut.Text.Length;
        rtbSerialOut.ScrollToCaret();
      }
    }

    private void SerialDataRecieved(object sender, SerialDataReceivedEventArgs e)
    {
      var sp = (SerialPort)sender;
      var input = sp.ReadExisting().Trim();

      SetText($"{input}{Environment.NewLine}");
    }
  }
}

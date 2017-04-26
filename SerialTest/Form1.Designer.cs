namespace SerialTest
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.btnOn = new System.Windows.Forms.Button();
      this.btnOff = new System.Windows.Forms.Button();
      this.cbSerialPorts = new System.Windows.Forms.ComboBox();
      this.btnSelectPort = new System.Windows.Forms.Button();
      this.btnReset = new System.Windows.Forms.Button();
      this.cbBaudRate = new System.Windows.Forms.ComboBox();
      this.rtbSerialOut = new System.Windows.Forms.RichTextBox();
      this.tbRawCmd = new System.Windows.Forms.TextBox();
      this.btnSendCmd = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnOn
      // 
      this.btnOn.Enabled = false;
      this.btnOn.Location = new System.Drawing.Point(12, 112);
      this.btnOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnOn.Name = "btnOn";
      this.btnOn.Size = new System.Drawing.Size(173, 28);
      this.btnOn.TabIndex = 0;
      this.btnOn.Text = "On";
      this.btnOn.UseVisualStyleBackColor = true;
      this.btnOn.Click += new System.EventHandler(this.onButton_Click);
      // 
      // btnOff
      // 
      this.btnOff.Enabled = false;
      this.btnOff.Location = new System.Drawing.Point(187, 112);
      this.btnOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnOff.Name = "btnOff";
      this.btnOff.Size = new System.Drawing.Size(173, 28);
      this.btnOff.TabIndex = 1;
      this.btnOff.Text = "Off";
      this.btnOff.UseVisualStyleBackColor = true;
      this.btnOff.Click += new System.EventHandler(this.offButton_Click);
      // 
      // cbSerialPorts
      // 
      this.cbSerialPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbSerialPorts.FormattingEnabled = true;
      this.cbSerialPorts.Location = new System.Drawing.Point(16, 15);
      this.cbSerialPorts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.cbSerialPorts.Name = "cbSerialPorts";
      this.cbSerialPorts.Size = new System.Drawing.Size(253, 24);
      this.cbSerialPorts.TabIndex = 2;
      // 
      // btnSelectPort
      // 
      this.btnSelectPort.Location = new System.Drawing.Point(279, 12);
      this.btnSelectPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnSelectPort.Name = "btnSelectPort";
      this.btnSelectPort.Size = new System.Drawing.Size(84, 28);
      this.btnSelectPort.TabIndex = 3;
      this.btnSelectPort.Text = "Select";
      this.btnSelectPort.UseVisualStyleBackColor = true;
      this.btnSelectPort.Click += new System.EventHandler(this.btnSelect_Click);
      // 
      // btnReset
      // 
      this.btnReset.Enabled = false;
      this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnReset.ForeColor = System.Drawing.Color.DarkRed;
      this.btnReset.Location = new System.Drawing.Point(13, 148);
      this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(347, 43);
      this.btnReset.TabIndex = 4;
      this.btnReset.Text = "Reset";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // cbBaudRate
      // 
      this.cbBaudRate.FormattingEnabled = true;
      this.cbBaudRate.Location = new System.Drawing.Point(16, 48);
      this.cbBaudRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.cbBaudRate.Name = "cbBaudRate";
      this.cbBaudRate.Size = new System.Drawing.Size(345, 24);
      this.cbBaudRate.TabIndex = 5;
      // 
      // rtbSerialOut
      // 
      this.rtbSerialOut.Location = new System.Drawing.Point(11, 198);
      this.rtbSerialOut.Name = "rtbSerialOut";
      this.rtbSerialOut.Size = new System.Drawing.Size(349, 200);
      this.rtbSerialOut.TabIndex = 6;
      this.rtbSerialOut.Text = "";
      // 
      // tbRawCmd
      // 
      this.tbRawCmd.Enabled = false;
      this.tbRawCmd.Location = new System.Drawing.Point(16, 83);
      this.tbRawCmd.Name = "tbRawCmd";
      this.tbRawCmd.Size = new System.Drawing.Size(253, 22);
      this.tbRawCmd.TabIndex = 7;
      // 
      // btnSendCmd
      // 
      this.btnSendCmd.Enabled = false;
      this.btnSendCmd.Location = new System.Drawing.Point(279, 80);
      this.btnSendCmd.Margin = new System.Windows.Forms.Padding(4);
      this.btnSendCmd.Name = "btnSendCmd";
      this.btnSendCmd.Size = new System.Drawing.Size(81, 28);
      this.btnSendCmd.TabIndex = 8;
      this.btnSendCmd.Text = "Send";
      this.btnSendCmd.UseVisualStyleBackColor = true;
      this.btnSendCmd.Click += new System.EventHandler(this.btnSend_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(379, 410);
      this.Controls.Add(this.btnSendCmd);
      this.Controls.Add(this.tbRawCmd);
      this.Controls.Add(this.rtbSerialOut);
      this.Controls.Add(this.cbBaudRate);
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.btnSelectPort);
      this.Controls.Add(this.cbSerialPorts);
      this.Controls.Add(this.btnOff);
      this.Controls.Add(this.btnOn);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(397, 457);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(397, 457);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Serial Test";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOn;
    private System.Windows.Forms.Button btnOff;
    private System.Windows.Forms.ComboBox cbSerialPorts;
    private System.Windows.Forms.Button btnSelectPort;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.ComboBox cbBaudRate;
    private System.Windows.Forms.RichTextBox rtbSerialOut;
    private System.Windows.Forms.TextBox tbRawCmd;
    private System.Windows.Forms.Button btnSendCmd;
  }
}


namespace JSONCBOR {
  partial class Form1 {
    /// <summary>Required designer variable.</summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>Clean up any resources being used.</summary>
    /// <param name='disposing'>True if managed resources should be disposed;
    /// otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>Required method for Designer support - do not modify the contents
    /// of this method with the code editor.</summary>
    private void InitializeComponent() {
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.jsonLabel = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.cborLabel = new System.Windows.Forms.Label();
      this.convertToJson = new System.Windows.Forms.Button();
      this.convertToCbor = new System.Windows.Forms.Button();
      this.SuspendLayout();
      //
      // button1
      //
      this.button1.Location = new System.Drawing.Point(89, 34);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(120, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Open JSON file...";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      //
      // label1
      //
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 40);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(49, 11);
      this.label1.TabIndex = 1;
      this.label1.Text = "JSON file";
      //
      // jsonLabel
      //
      this.jsonLabel.AutoSize = true;
      this.jsonLabel.Location = new System.Drawing.Point(87, 77);
      this.jsonLabel.Name = "jsonLabel";
      this.jsonLabel.Size = new System.Drawing.Size(83, 11);
      this.jsonLabel.TabIndex = 2;
      this.jsonLabel.Text = "-------------";
      this.jsonLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      //
      // label3
      //
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 115);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(50, 11);
      this.label3.TabIndex = 3;
      this.label3.Text = "CBOR file";
      //
      // button2
      //
      this.button2.Location = new System.Drawing.Point(89, 103);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(120, 23);
      this.button2.TabIndex = 4;
      this.button2.Text = "Open CBOR file...";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      //
      // cborLabel
      //
      this.cborLabel.AutoSize = true;
      this.cborLabel.Location = new System.Drawing.Point(87, 150);
      this.cborLabel.Name = "cborLabel";
      this.cborLabel.Size = new System.Drawing.Size(83, 11);
      this.cborLabel.TabIndex = 5;
      this.cborLabel.Text = "-------------";
      this.cborLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      //
      // convertToJson
      //
      this.convertToJson.Enabled = false;
      this.convertToJson.Location = new System.Drawing.Point(229, 103);
      this.convertToJson.Name = "convertToJson";
      this.convertToJson.Size = new System.Drawing.Size(122, 23);
      this.convertToJson.TabIndex = 6;
      this.convertToJson.Text = "Convert to JSON...";
      this.convertToJson.UseVisualStyleBackColor = true;
 this.convertToJson.Click += new System.EventHandler(this.convertToJson_Click);
      //
      // convertToCbor
      //
      this.convertToCbor.Enabled = false;
      this.convertToCbor.Location = new System.Drawing.Point(229, 34);
      this.convertToCbor.Name = "convertToCbor";
      this.convertToCbor.Size = new System.Drawing.Size(122, 23);
      this.convertToCbor.TabIndex = 7;
      this.convertToCbor.Text = "Convert to CBOR...";
      this.convertToCbor.UseVisualStyleBackColor = true;
 this.convertToCbor.Click += new System.EventHandler(this.convertToCbor_Click);
      //
      // Form1
      //
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(386, 182);
      this.Controls.Add(this.convertToCbor);
      this.Controls.Add(this.convertToJson);
      this.Controls.Add(this.cborLabel);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.jsonLabel);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "JSON/CBOR Converter";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label jsonLabel;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label cborLabel;
    private System.Windows.Forms.Button convertToJson;
    private System.Windows.Forms.Button convertToCbor;
  }
}
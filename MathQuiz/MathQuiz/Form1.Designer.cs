namespace MathQuiz
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
      this.timeLabel = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.plusLeftLabel = new System.Windows.Forms.Label();
      this.plusRightLabel = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.sum = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
      this.SuspendLayout();
      // 
      // timeLabel
      // 
      this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.timeLabel.Location = new System.Drawing.Point(272, 9);
      this.timeLabel.Name = "timeLabel";
      this.timeLabel.Size = new System.Drawing.Size(200, 30);
      this.timeLabel.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(165, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(101, 25);
      this.label1.TabIndex = 1;
      this.label1.Text = "Time Left";
      // 
      // plusLeftLabel
      // 
      this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.plusLeftLabel.Location = new System.Drawing.Point(50, 75);
      this.plusLeftLabel.Name = "plusLeftLabel";
      this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
      this.plusLeftLabel.TabIndex = 2;
      this.plusLeftLabel.Text = "?";
      this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // plusRightLabel
      // 
      this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.plusRightLabel.Location = new System.Drawing.Point(182, 75);
      this.plusRightLabel.Name = "plusRightLabel";
      this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
      this.plusRightLabel.TabIndex = 3;
      this.plusRightLabel.Text = "?";
      this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(116, 75);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(60, 50);
      this.label3.TabIndex = 4;
      this.label3.Text = "+";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(248, 75);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 50);
      this.label2.TabIndex = 5;
      this.label2.Text = "=";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // sum
      // 
      this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.sum.Location = new System.Drawing.Point(314, 84);
      this.sum.Name = "sum";
      this.sum.Size = new System.Drawing.Size(100, 35);
      this.sum.TabIndex = 6;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 361);
      this.Controls.Add(this.sum);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.plusRightLabel);
      this.Controls.Add(this.plusLeftLabel);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.timeLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Math Quiz";
      ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label timeLabel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label plusLeftLabel;
    private System.Windows.Forms.Label plusRightLabel;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown sum;
  }
}


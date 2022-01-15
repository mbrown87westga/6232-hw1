using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
  public partial class Form1 : Form
  {
    Random randomizer = new Random();

    int addend1;
    int addend2;

    public Form1()
    {
      InitializeComponent();
    }

    public void StartTheQuiz()
    {
      addend1 = randomizer.Next(51);
      addend2 = randomizer.Next(51);

      plusLeftLabel.Text = addend1.ToString();
      plusRightLabel.Text = addend2.ToString();
      
      sum.Value = 0;
    }

    private void startButton_Click(object sender, EventArgs e)
    {
      StartTheQuiz();
      startButton.Enabled = false;
    }
  }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_14_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            toolCmbSize.Items.AddRange(new object[] {8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72});
            toolCmbSize.Text = textBox1.Font.Size.ToString();
            toolCmbSize.TextChanged += new System.EventHandler(this.toolCmbSize_TextChanged);
            toolButtonB.Click += new System.EventHandler(this.toolButton_Click);
            toolButtonB.Text = "B";
            toolButtonB.BackColor = Color.Transparent;
            toolButtonI.Click += new System.EventHandler(this.toolButton_Click);
            toolButtonI.Text = "I";
            toolButtonI.BackColor = Color.Transparent;
            toolButtonU.Click += new System.EventHandler(this.toolButton_Click);
            toolButtonU.Text = "U";
            toolButtonU.BackColor = Color.Transparent;
            toolButtonLeft.Click += new System.EventHandler(this.toolButton_Click);
            toolButtonLeft.Text = "Left";
            toolButtonLeft.BackColor = Color.LightBlue;//differnce
            toolButtonCenter.Click += new System.EventHandler(this.toolButton_Click);
            toolButtonCenter.Text = "Center";
            toolButtonCenter.BackColor = Color.Transparent;
            toolButtonRight.Click += new System.EventHandler(this.toolButton_Click);
            toolButtonRight.Text = "Right";
            toolButtonRight.BackColor = Color.Transparent;
            textBox1.Focus();
        }
        //------------------------------------------------------------------
        private void toolButton_Click(object sender, EventArgs e)
        {
            //tool buttons click
            ToolStripButton tsb = (ToolStripButton)sender;
            //3 dokmeye tarazbandi
            if (tsb.Text == "Left" || tsb.Text == "Center" || tsb.Text == "Right")
            {
                toolButtonLeft.BackColor = Color.Transparent;
                toolButtonRight.BackColor = Color.Transparent;
                toolButtonCenter.BackColor = Color.Transparent;
                tsb.BackColor = Color.LightBlue;
            }
            //other dokmeha-------------------------------
            else
            {
                if (tsb.BackColor == Color.Transparent)
                {
                    tsb.BackColor = Color.LightBlue;
                }
                else
                {
                    tsb.BackColor = Color.Transparent;
                }
            }
            //--------------emal tanzimat----------------------------
            FontStyle bold = (toolButtonB.BackColor == Color.Transparent) ? FontStyle.Regular : FontStyle.Bold;
            FontStyle italic = (toolButtonI.BackColor == Color.Transparent) ? FontStyle.Regular : FontStyle.Italic;
            FontStyle underline = (toolButtonU.BackColor == Color.Transparent) ? FontStyle.Regular : FontStyle.Underline;
            textBox1.Font = new System.Drawing.Font(textBox1.Font.FontFamily, float.Parse(toolCmbSize.Text), bold | italic | underline);
            if (toolButtonLeft.BackColor == Color.LightBlue)
                textBox1.TextAlign = HorizontalAlignment.Left;
            else if (toolButtonRight.BackColor == Color.LightBlue)
                textBox1.TextAlign = HorizontalAlignment.Right;
            else
                textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Focus();
        }
        //------------------------------------------------------------------
        private void toolCmbSize_TextChanged(object sender, EventArgs e)
        {
            //change font size
            float size=0;
            if (float.TryParse(toolCmbSize.Text, out size))
                textBox1.Font = new Font(textBox1.Font.FontFamily, size, textBox1.Font.Style);
            else//Error Not Enter Digit!
            {
                MessageBox.Show("Font Size Is Error!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                toolCmbSize.Text = textBox1.Font.Size.ToString();
            }
        }
    }
}

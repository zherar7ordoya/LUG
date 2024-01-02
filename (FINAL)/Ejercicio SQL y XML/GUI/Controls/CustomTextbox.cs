using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CustomTextbox : UserControl
    {
        public enum Directions
        {
            Left, Right, Top, Bottom
        }

        [Description("Define the Text Property of label")]
        public string Description
        {
            get
            {
                return label1.Text;
            }

            set
            {
                label1.Text = value;
            }
        }

        [Description("Define the location of label")]
        public Point LabelLocation
        {
            get
            {
                return label1.Location;
            }
            set
            {
                label1.Location = value;
            }
        }

        [Description("Define the location of Textbox")]
        public Point TextboxLocation
        {
            get
            {
                return textBox1.Location;
            }
            set
            {
                textBox1.Location = value;
            }
        }
        [Description("Set Password Character Input in Textbox")]
        public char PasswordChar
        {
            get
            {
                return textBox1.PasswordChar;
            }

            set
            {
                textBox1.PasswordChar = value;
            }
        }

        [Description("Set the Multiline feature of Textbox")]
        public bool MultiLine
        {
            get
            {
                return textBox1.Multiline;
            }
            set
            {
                textBox1.Multiline = value;
            }
        }

        public CustomTextbox()
        {
            InitializeComponent();
        }
    }
}

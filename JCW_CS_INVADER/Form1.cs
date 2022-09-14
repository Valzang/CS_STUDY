using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using JCW_CS_INVADER.Object;

namespace JCW_CS_INVADER
{
    public partial class Invader : Form
    {
        public Invader()
        {
            InitializeComponent();
            GameObject gameObject = new GameObject();
            gameObject.SetScreenSize(ClientRectangle);
        }

        private void Invader_Load(object sender, EventArgs e)
        {

        }
    }
}

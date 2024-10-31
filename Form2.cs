using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B8D55
{
    public partial class Form2 : Form
    {
        //public static Form2 Instance;
        public Label _ten;
        public Label _ngaysinh;
        public Label _quequan;
        public Label _lop;
        public Form2()
        {
            InitializeComponent();
            //Instance = this;
            _ten = this.ten;
            _ngaysinh = this.ngaysinh;
            _quequan = this.quequan;
            _lop = this.lop;
        }
    }
}

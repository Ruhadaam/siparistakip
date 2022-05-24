using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siparistakip
{
    public partial class Tamamlanan : Form
    {
        public Tamamlanan()
        {
            InitializeComponent();
        }

        private void Tamamlanan_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'elbiseSiparisDataSet2.tamamlanansiparis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tamamlanansiparisTableAdapter.Fill(this.elbiseSiparisDataSet2.tamamlanansiparis);

        }
    }
}

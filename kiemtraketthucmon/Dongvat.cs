using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace kiemtraketthucmon
{
    class Dongvat
    {
        private string Keu;

        public string tiengkeu
        {
            get { return Keu; }
            set { Keu = value; }
        }
        public Dongvat()
        {
        }
        private string Maulong;
        public string longdongvat
        {
            get { return Maulong; }
            set { Maulong = value; }
        }
    
        public virtual void Talk()
        {
            if (tiengkeu.Equals("Gâu gâu") && (longdongvat.Equals("Đỏ")))
                MessageBox.Show(this.tiengkeu + " Tôi là chó lông màu:" + this.longdongvat);
            else if (tiengkeu.Equals("Meo meo") && (longdongvat.Equals("Đỏ")))
                MessageBox.Show(this.tiengkeu + " Tôi là mèo lông màu:" + this.longdongvat);
        }
    }
}

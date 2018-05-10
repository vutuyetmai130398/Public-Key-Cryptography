using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Threading;

namespace UCLN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnResult_Click(object sender, EventArgs e)
        {
            BigInteger result=0;
            
            if(!string.IsNullOrEmpty(rtbNum1.Text) && !string.IsNullOrEmpty(rtbNum2.Text))
            {
                result = GCD(BigInteger.Parse(rtbNum1.Text), BigInteger.Parse(rtbNum2.Text));
                rtbResult.Text = result.ToString();
                return;
            }

            Randomnumber rnd = new Randomnumber();

            Random random = new Random(DateTime.Now.Millisecond);
            BigInteger num1 = rnd.getRandom(random.Next(1, 65));

            random = new Random(DateTime.Now.Millisecond);
            BigInteger num2 = rnd.getRandom(random.Next(1, 65));
                  

            rtbNum1.Text = num1.ToString();
            rtbNum2.Text = num2.ToString();

            result = GCD(num1, num2);
           
            rtbResult.Text = result.ToString();
        }

        public BigInteger GCD(BigInteger num1, BigInteger num2)
        {
            if (num1 == 0)
                return num2;
            if (num2 == 0)
                return num1;

            if (num1 > num2)
                return GCD(BigInteger.ModPow(num1, 1, num2), num2);
            else
                return GCD(num1, BigInteger.ModPow(num2, 1, num1));
        }
        

    }
}

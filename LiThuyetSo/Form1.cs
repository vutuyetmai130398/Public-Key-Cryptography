using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LiThuyetSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        //Exercise 1:

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            rtbResult.Text += GeneratePrime(int.Parse(tbBits.Text))+"\n";
        }

        Primality primality = new Primality();

        private string GeneratePrime(int length)
        {
            string numbers = "";

            RandomNumber rndNum = new RandomNumber();

            BigInteger number = rndNum.getRandom(length);

            if(primality.IsPrimeMillerRabin(number))
            {
                numbers = number.ToString();
                return numbers;
            }
            else
            {
                return GeneratePrime(length);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //Excercise 2:
        private void btnTest_Click(object sender, EventArgs e)
        {
            TestNumber(BigInteger.Parse(txtNumberTest.Text));
        }

        private void TestNumber(BigInteger number)
        {
            if (primality.IsPrimeMillerRabin(number))
                MessageBox.Show("Correct!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Incorrect!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNumberTest.Clear();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            RandomNumber _rnd = new RandomNumber();
            txtNumberTest.Text = _rnd.getRandom(89).ToString();
        }

        //Exercise 3:
        private void btnCal_Click(object sender, EventArgs e)
        {
            FilterPrime fm = new FilterPrime();
            List<BigInteger> _Mesrsenes = fm.MersenneResult();

            int i = 0;
            List<BigInteger> _PrimeWithoutMersenne=fm.FilterPrimeNumber(i, _Mesrsenes.ElementAt(0));
            int length = 10;

            while (i < 10)
            {
                rtbResultPrimes.Text += "The prime numbers less than " + _Mesrsenes.ElementAt(i) +"\n";
                rtbMersenne.Text += _Mesrsenes.ElementAt(i) + "\n";
                int j = 0;
                while (j < length) {
                    if ((length=_PrimeWithoutMersenne.Count) < 10)
                    {
                        rtbResultPrimes.Text += "\t" + _PrimeWithoutMersenne.ElementAt(j)+"\n";
                        j++;
                    }
                    else
                    {
                        length = 10;
                        rtbResultPrimes.Text += "\t" + _PrimeWithoutMersenne.ElementAt(j)+"\n";
                        j++;
                    }
                    
               }
                if (i == 9) break;
                 _PrimeWithoutMersenne = fm.FilterPrimeNumber(_Mesrsenes.ElementAt(i++), _Mesrsenes.ElementAt(i));
                
            }
            
        }
        
    }
}

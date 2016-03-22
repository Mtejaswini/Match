using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using System.Windows.Forms;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;


namespace WordsMatching
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }

        void Test_1()
        {
            SentenceSimilarity semsim = new SentenceSimilarity();

            float score = 0;

            // System.Console.WriteLine("car: ");
       
            score = semsim.GetScore(
            richTextBox1.Text,
           richTextBox2.Text);
            DiplScore.Text = score.ToString();

           
        }
        private void button1_Click(object sender, EventArgs e)
        {

         //   MessageBox.Show("button");

            Wnlib.WNCommon.path = "C:\\Program Files (x86)\\WordNet\\2.1\\dict\\";

            //Wnlib.WNCommon.path = "D:\\wn_15.sdb";

            string strTranslatedText1 = null;
            string strTranslatedText2 = null;

            try
            {

                TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient("BasicHttpBinding_LanguageService");
                client = new TranslatorService.LanguageServiceClient("BasicHttpBinding_LanguageService");
             
                strTranslatedText1 = client.Translate("XM5qyTSXAh7JxjRC0rxr5fAT9pkMoSRJUQXI589aj/g", richTextBox1.Text, "", "en");
                richTextBox1.Text = strTranslatedText1;
                //MessageBox.Show(strTranslatedText1);
                strTranslatedText2 = client.Translate("XM5qyTSXAh7JxjRC0rxr5fAT9pkMoSRJUQXI589aj/g", richTextBox2.Text, "", "en");
                richTextBox2.Text = strTranslatedText2;

                strTranslatedText1 = richTextBox1.Text;
                strTranslatedText2 = richTextBox2.Text;
                Test_1();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiplScore_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

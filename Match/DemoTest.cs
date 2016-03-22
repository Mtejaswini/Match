using System;
using System.Diagnostics;
using System.Text.RegularExpressions ;
using System.Windows.Forms;

namespace WordsMatching
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class DemoTest
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{

           // DemoForm DF = new DemoForm();

           // DF.Show();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DemoForm()); 

			// TDMS 21 Sept 2005 - added dictionary path
            //System.Console.WriteLine("Welcome: ");
            
            //Wnlib.WNCommon.path = "C:\\Program Files (x86)\\WordNet\\2.1\\dict\\";

			//DemoTest t=new DemoTest() ;

            //Console.ReadKey();
		}

        void Test_1()
        {


           // MessageBox.Show("button");

 SentenceSimilarity semsim = new SentenceSimilarity();

 float score = 0;

 //System.Console.WriteLine("car: ");

          
 score = semsim.GetScore(
 "People like listening music",
 "people never listen son");
 System.Console.WriteLine("second: " + score);

 score = semsim.GetScore(
 "I love driving car",
 "vehicle is moving by me");
 System.Console.WriteLine("third: " + score);

 /*
 score = semsim.GetScore(
 "flora",
 "person");
 System.Console.WriteLine("Score: " + (score == 0.83F));

 score = semsim.GetScore(
  "boy",
  "teacher");
 System.Console.WriteLine("Score: " + (score == 0.57F));

 //is cursing the boy?
 score = semsim.GetScore(
 "boy",
 "animal");
 System.Console.WriteLine("Score: " + (score == 0.71F));
 */
        }
        public DemoTest() //NUnit missing! 
		{
           //Test_1();
           // SemanticSimilarity semsim = new SemanticSimilarity();
           // float score = semsim.GetScore("Defense Ministry", "Department of defence"); //0.75
            //score = semsim.GetScore("Tom is a doctor", "Tom is a teacher");
            //score = semsim.GetScore("car", "auto");			
			//float score = semsim.GetScore("Pepsi is being drunk by Shilpa", "Shilpa is drinking pepsi");
			
			int i=1;
			
			//Trace.WriteLine(match.Score) ;			
		}

	}
}

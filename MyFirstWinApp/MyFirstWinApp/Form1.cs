using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinApp
{
    public partial class Form1 : Form
    {
        EventHandler ProcessSelectedText;
        delegate void BulkTextWriter(string source, string target);

        public delegate void TakeSafetyMeasures();
        


        public string[] syntaxTokens = { "MessageBox.Show", "MessageBoxButtons.OK", "MessageBoxIcon.Information", };


        public static class AppFiles
        {
            public static class ConsoleTextFile
            {
                public static string Name = "GraficConsole.txt";
                public  static string Path = System.IO.Directory.GetCurrentDirectory();
                public static string TheFileComplete = System.IO.Path.Combine(AppFiles.ConsoleTextFile.Path, AppFiles.ConsoleTextFile.Name);


            }
        }

        //===========================================================
        //change the contents here 
        //===========================================================

        private void FindContents(object generlSentObject_RTB, EventArgs e) //one of teh many things that we can do to 
                                                              //the slected text!

        {
            //the body of the event that ought to fire 

            //when the user is in the grafic Console
            //and, hee ha sselected text
            //text thas my slected key words
            //
            // the user defined event is a combo of standeards events
            //or an if condition anywhere in the code is ssatisfied !
            //
            //we tqke situation 1.

            /*
                           ("Selection Process succeeded!"
                          , "EVENT DID FIRE AS EXPECTED!!!!!", MessageBoxButtons.OK
                              , MessageBoxIcon.Information)MessageBox.Show;
            */

            //we will collect the caption and the title
            //  string ourText = GraficConsole.SelectedText;
            //int indexToOpenParen = 1; //ourText. .Find(syntaxTokens[0], 0);

            //  int indexToCaption = indexToOpenParen + syntaxTokens[0].Length + 3;
            //  if (indexToCaption > GraficConsole.SelectedText.Length)
            //      //put error msg here
            //      return;

            //int indexToCloseQuote = indexToCaption + syntaxTokens[0].Length + 1;



            //Added block Jeevan03242018
            RichTextBox sender = (RichTextBox)generlSentObject_RTB;

            string[] syntaxTokensSome = { syntaxTokens[0] , syntaxTokens[1]};

            foreach (string word in syntaxTokensSome)
            {
                int startIndex = 0;
                while (startIndex < sender.TextLength)
                {
                    int wordStartIndex = sender.Find(word, startIndex, RichTextBoxFinds.None);
                    if(wordStartIndex != -1)
                    {
                        sender.SelectionStart = wordStartIndex;
                        sender.SelectionLength = word.Length;
                        sender.SelectionBackColor = Color.Yellow;
                    }
                    else
                    {
                        break;
                    }
                    startIndex = wordStartIndex + word.Length;
                }
            }
            //end added
            //HOMEWORK FOR 15 TH APRIL
            //CONVERT ABV FOREACH TO A FUNCTION DLEEGATE
            //THAT IS ALL

            return;
        }


        //===========================================================
        //change the contents here 
        //===========================================================
        private void ChangeContents(object sender, EventArgs e)

        {
            //the body of the event that ought to fire 

            //when the user is in the grafic Console
            //and, hee ha sselected text
            //text thas my slected key words
            //
            // the user defined event is a combo of standeards events
            //or an if condition anywhere in the code is ssatisfied !
            //
            //we tqke situation 1.


            return;
        }


        public Form1()
        {
            InitializeComponent();

            /*
            //next
            //so, methid three 
            //not in here , but ...
            GraficConsole.DoubleClick += Save_Click; //add one more event to the prev event !
                                                     //we are free to add any amount !
            GraficConsole.AppendText("We have just added save to dbl clk for grafic console" + Environment.NewLine);

            MessageBox.Show("Blank out will delete everything from a file. Do you want to continue?"
                                    , "Clear Out", MessageBoxButtons.OK
                                        , MessageBoxIcon.Information);
            */


        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //GraficConsole.l
            GraficConsole.Focus();

            

        }



        private void Save_Click(object sender, EventArgs e)
        {
            //please explore the combine command for better app creation
            //string TheFileComplete  = System.IO.Path.Combine(AppFiles.ConsoleTextFile.Path, AppFiles.ConsoleTextFile.Name);


            //we define the lambda expression/functio here ... 
           BulkTextWriter AppendBulkText = (string FileNameAndPath, string targetBlock) =>
            {
                GraficConsole.AppendText(Environment.NewLine + "We have just added \'save\' to the grafic console" + Environment.NewLine);
                System.IO.File.AppendAllText(FileNameAndPath, targetBlock);
            };

            GraficConsole.AppendText(Environment.NewLine + "using the Save Lambda here ..." + Environment.NewLine);
            //call the lambda expression/functio here, immediately!
            AppendBulkText(AppFiles.ConsoleTextFile.TheFileComplete, GraficConsole.Text);



            GraficConsole.DoubleClick += Clear_Click; //next time onwards !
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            //copied from blankout for sake of better coding !
            MessageBox.Show("Blank out will delete everything from a file. Do you want to continue?"
                                    , "Blank Out", MessageBoxButtons.OK
                                        , MessageBoxIcon.Information);
            System.IO.File.WriteAllText(".\\GraficConsole.txt", string.Empty);


            GraficConsole.DoubleClick += delegate //we can make a custom made method ans add it on the fly !
            {
                GraficConsole.AppendText(Environment.NewLine + " A EVENT MANAGER ON THE FLY HAS BEEN ADDED TO THE CONSOLE!" + Environment.NewLine);
                MessageBox.Show("SHOULD WE CONTINUE?"
                        , "APPENDED A DELEGATE", MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
            };
           //further processing 
//            TakeSafetyMeasures ConsoleSafetyMeasure = delegate { GraficConsole.Text = string.Empty; };

            TakeSafetyMeasures ConsoleSafetyMeasure = new TakeSafetyMeasures(FileSafetyMeasure);

            ConsoleSafetyMeasure();

            GraficConsole.Text = string.Empty;
            GraficConsole.DoubleClick -= Clear_Click;



        }

        void FileSafetyMeasure()
            {
            System.IO.File.AppendAllText(AppFiles.ConsoleTextFile.TheFileComplete, GraficConsole.Text);
            return;
            }


    private void Retrieve_Click(object sender, EventArgs e)
        {
            //declare the action here 
            Action<RichTextBox, string> RetrieveWithoutError;

            //define the action,  = method body 
            RetrieveWithoutError = delegate (RichTextBox GC, string FC)
           {
               try
               {
                   GC.AppendText(File.ReadAllText(".\\GraficConsole.txt"));
               }
               catch (Exception)
               {
                   using (StreamWriter w = File.AppendText(FC))
                   {
                       ;
                   }

               }
           };

            GraficConsole.AppendText(Environment.NewLine + "using the Retrive Action here ..." + Environment.NewLine);
            //call the action here
            RetrieveWithoutError(GraficConsole, AppFiles.ConsoleTextFile.TheFileComplete);


            }

            
        

        private void GraficConsole_Leave(object sender, EventArgs e)
        {
            //un define the useerdefined event
            ProcessSelectedText -= FindContents;
            ProcessSelectedText -= ChangeContents;
            


        }

        private void Highlight_Click(object sender, EventArgs e)
        {
            GraficConsole.Focus();
            GraficConsole.SelectAll();
        }

        private void BlankOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Blank out will delete everything from a file. Do you want to continue?"
                                    ,"Blank Out", MessageBoxButtons.YesNoCancel
                                        ,MessageBoxIcon.Question);
            System.IO.File.WriteAllText(".\\GraficConsole.txt", string.Empty);
            GraficConsole.Text = string.Empty;
        }

        private void GraficConsole_DoubleClick(object sender, EventArgs e)
        {
            GraficConsole.AppendText("We have just dbl clicked  the grafic console" + Environment.NewLine);

            return;  // we pre empt the calls below 

            /*
            //here, i want to call a button event
            //i choose to call Save
            //way # 1 of doing it!
            //repeat the method entirely !!!!
            System.IO.File.AppendAllText(AppFiles.ConsoleTextFile.TheFileComplete, GraficConsole.Text);
            // the disaDVANTAGE IS , TOO MANY COPIES TOP BE MADE

            //SO,METHOD 2 
            //call it 
            Save_Click( sender, e);
            //nothing look wrong here 
            //but, the stattement is hard coded here 
            */


        }

        private void GraficConsole_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Save_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Save_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                MessageBox.Show("GRAFIC file will be over-written !"
                            , "Clear Out", MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                System.IO.File.WriteAllText(AppFiles.ConsoleTextFile.TheFileComplete, GraficConsole.Text);
            } //a crude arrangement !!!!

        }

        private void GraficConsole_SelectionChanged(object sender, EventArgs e)

        {
            //situation 1.a.  - the seection process is on 
            //now to search for thE key words of interest
            //return;
            //IF KEY WORDS ARE ALL FOUND !! THEN .....
            Predicate<int> CheckZero;

            CheckZero = delegate (int LengthVar) //it is a dfelegate 
            {
                if (LengthVar == 0)
                    return true;
                else
                    return false;
            };

            if (CheckZero(GraficConsole.SelectedText.Length)) return;


            Func<string, string, string, bool> F_GC_Content; //1. declare a function delegate 
                                                             //last arguemenmt is a return type, bool in this case


            //2. define the funcction, it takes 3 strings, returns a bool
            F_GC_Content = delegate (string tkn1, string tkn2, string tkn3)
            {
                if (GraficConsole.SelectedText.Contains(tkn1) &
                    GraficConsole.SelectedText.Contains(tkn2) &
                    GraficConsole.SelectedText.Contains(tkn3))

                    return true;
                else
                    return false;

            };

            //3. call the delegate function 
            //we do it with ... syntaxtokens, 0, 1, 2
            if (F_GC_Content(syntaxTokens[0], syntaxTokens[1],syntaxTokens[2]) == false)
                return;


                
              


/*
            MessageBox.Show("Selection Process is on!"
               , "EVENT TO FIRE NOW !!!!!", MessageBoxButtons.OK
                   , MessageBoxIcon.Information);
*/

            ProcessSelectedText(GraficConsole, e);
            //it werks !!!!! up to here 

            //GiveFeedback a function call here and matter issorted !!!
            //
            //as if i have already defined them ??!!!!
            //fire userdefinedevent !!!


        }

        private void GraficConsole_Enter(object sender, EventArgs e)
        {
            //we appoint the user defined event 
            //we have an event
            //UserDefinedEvent ready to be fired 
            ProcessSelectedText += FindContents;
            ProcessSelectedText += ChangeContents;




        }

        private void End_Click(object sender, EventArgs e)
        {
            Action EndApplication;

            EndApplication = delegate
           {
               System.IO.File.WriteAllText(AppFiles.ConsoleTextFile.TheFileComplete, GraficConsole.Text);

           };

            EndApplication();
            Application.Exit();
        }
    }
}


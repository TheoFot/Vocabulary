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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Vocabulary
{
    class Vok
    {
        private static string z;
        public  string Z
        {
            get { return z; }


            set { z = value; }

            
        }


       
       
       
    }

    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {


        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string path = @"D:\Gittset\Vocabulary\Vocabulary\Vocabularywords.txt";
            using (StreamReader Vocabulary = new StreamReader(path)) ;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {

                string linefromVocabulary;
                string[] WordstoTranslate = new string[350];
                string[] TranslatedWords = new string[350];

                try
                {



                    for (int i = 0, k = 0; (linefromVocabulary = sr.ReadLine()) != null; i++, k++)
                    {
                        string[] wordForTranslate = linefromVocabulary.Split(new char[] { '-' });

                        string word = wordForTranslate[0];
                        string translatedword = wordForTranslate[1];


                        WordstoTranslate[i] = word;
                        TranslatedWords[k] = translatedword;

                    }
                }
                catch

                {
                    string a = "Щось пішло не так";
                    textBox1.Text = Convert.ToString(a);
                }



                Random random = new Random();
                int randomWord = random.Next(350);
                Vok wordtotranslate = new Vok();
                wordtotranslate.Z = TranslatedWords[randomWord];
                
                textBox1.Clear();
                textBox1.Text = Convert.ToString("Напишіть переклад слова " + WordstoTranslate[randomWord]);

                textBox2.Clear();
                textBox3.Clear();
               
               


    }

        }
    
        

        private void button3_Click(object sender, EventArgs e)
        {
          Vok wordtoTranslate = new Vok();

            string WordtoTranslate = wordtoTranslate.Z;

            string translatedWord = Convert.ToString(textBox2.Text);

            if (WordtoTranslate == translatedWord)
            {
                textBox3.Text = "Все правильно!";


            }
            else
            {

                textBox3.Text = ("Праввильна відповідь : " + Convert.ToString(WordtoTranslate));

            }



        }
    }
}

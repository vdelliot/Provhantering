using System.Reflection.Emit;

namespace Provhantering
{
    public partial class Form1 : Form
    {
        private int currentQuestion;
        string[] arr = {"" , "1. Datorprogram i form av ettor och nollor. ", "1. Ett program som laddar upp kod på hemsidor. ", "1. En programmeringsmetod där programmet har flertal olika objet som interagerar med varann.", "1. En artifciell-intelligens som lär sig genom att söka på webben.", "1. 1943", "1. Ja", "1. Antalet transistorer på en integrerad krets fördubblats ungefär vartannat år, vilket har gjort att datorer blir kraftfullare över tiden." };
        string[] arr1 = { "","2. Datorprogram i form av treor och tvåor. ", "2. Ett program som översätter programspråket åt datorn.", "2. En programmeringsmetod där programmet skapar objekt av sig själv. ", "2. Ett program som lär ut till elever. ", "2. 1946", "2. Nej", "2. Datorprestanda har förbättrats på grund av förbättringar i datorarkitektur, oberoende av antalet transistorer." };
        string[] arr2 = { "","3. Datorprogram i form av tvåor och nollor.", "3. Ett program som strukturerar datorns filsystem.", "3. Ett programmeringstankesätt där man sorterar områden till objekt. ", "3. En artificiell-intelligens som lär sig sakta genom att tränas på användarinput.", "3. 1834. ", "3. Nej och Ja", "3. Moore's lag har främst tillämpats inom bioteknik, vilket har lett till snabbare utveckling av mediciner och behandlingar för olika sjukdomar." };
        string[] arr3 = { "", "4. Datorprogram i form av ettor och treor.", "4. Ett program som skapar kalkulationer.", "4. Ett program som 3d skriver objekt.", "4. En utbildning om maskiner. ", "4. 1910", "4. Går inte att svara på", "4. Moore's lag är en ekonomisk teori som förutsäger att efterfrågan på datorer kommer att växas på grund av ökad tillgänglighet." };
        string[] questions = { "Vad kan du inte programmera en dator till att göra?",  "Vad betyder binär kod?", "Vad gör en kompilator?", "Vad menas det med att ett språk är objektorienterat?", "Vad menas med maskininlärning?", "När skapades den första programmerbara datorn?", "Ta ställning till följande seriebild, är exemplet utdaterat?", "Vilket av följande val beskriver Moores lag?", "Kommer Moores lag att följas i framtiden?", "Förklara vad Open-source är, redogör för dess nackdelar och fördelar.", "Varför är det viktigt att hålla en konsekvent kodningstil?", "Varför behöver applikationer olika versioner för olika operativsystem?", "Hur har AI påverkat programmerings möjligheter och begränsningar?" , "Test done!" };
        List<string> Answers; 
        List<string> AnswersWritten;
        public Form1()
        {
            currentQuestion = 0;
            Answers = new List<string>(); 
            InitializeComponent();
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/results.txt";
            StreamWriter sw;

            if (File.Exists(docPath))
            {
                sw = File.AppendText(docPath);
            } else
            {
                sw = File.CreateText(docPath);
            }
            sw.WriteLine("");
        }

        private void question_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            button1.Visible = false;
            question.Visible = true;
            button2.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            question.Visible = false;
            checkBox1.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            checkBox5.Visible = true;
            checkBox6.Visible = true;
            checkBox7.Visible = true;
            flowLayoutPanel2.Visible = true;
            for(int i = 0; i < Answers.Count; i++)
            {
                MessageBox.Show(Answers[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentQuestion++;
            if (currentQuestion == 13)
            {
                Answers.Add(currentQuestion - 1 + ". " + textBox1.Text);
                textBox1.Visible = false;
                button2.Visible = false;
                question.Text = "Test done! Click on the results button to see your results.";
                button3.Visible = true;
            }
            else if (currentQuestion >= 8)
            {                            if(currentQuestion > 8)
                {
                    Answers.Add(currentQuestion-1 + ". " + textBox1.Text);
                }    
                
                textBox1.Visible = true;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                question.Text = questions[currentQuestion];


            }
            else
            {

                List<RadioButton> answers = flowLayoutPanel1.Controls.OfType<RadioButton>().ToList();
                for (int i = 0; i < answers.Count; i++)
                {
                    if (answers[i].Checked)
                    {

                        Answers.Add(currentQuestion + ". " + answers[i].Text);
                        radioButton1.Text = arr[currentQuestion];
                        radioButton2.Text = arr1[currentQuestion];
                        radioButton3.Text = arr2[currentQuestion];
                        radioButton4.Text = arr3[currentQuestion];
                        question.Text = questions[currentQuestion];

                        

                    } 

                }
            }

            if (currentQuestion == 7)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

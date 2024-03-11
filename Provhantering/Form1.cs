using System.Reflection.Emit;

namespace Provhantering
{
    public partial class Form1 : Form
    {
        private int currentQuestion;
        string[] arr = { "1. Datorprogram i form av ettor och nollor. ", "1. Ett program som laddar upp kod p� hemsidor. ", "1. En programmeringsmetod d�r programmet har flertal olika objet som interagerar med varann.", "1. En artifciell-intelligens som l�r sig genom att s�ka p� webben.", "1. 1943", "1. Ja", "1. Under de senaste �ren har antalet transistorer p� en integrerad krets f�rdubblats ungef�r vartannat �r, vilket har m�jliggjort att datorer blir mindre och kraftfullare �ver tiden." };
        string[] arr1 = { "2. Datorprogram i form av treor och tv�or. ", "2. Ett program som �vers�tter programspr�ket �t datorn.", "2. En programmeringsmetod d�r programmet skapar objekt av sig sj�lv. ", "2. Ett program som l�r ut till elever. ", "2. 1946", "2. Nej", "2. Under de senaste �ren har datorprestanda f�rb�ttrats p� grund av optimering av programvara och f�rb�ttringar i datorarkitektur, oberoende av antalet transistorer." };
        string[] arr2 = { "3. Datorprogram i form av tv�or och nollor.", "3. Ett program som strukturerar datorns filsystem.", "3. Ett programmeringstankes�tt d�r man sorterar omr�den till objekt. ", "3. En artificiell-intelligens som l�r sig sakta genom att tr�nas p� anv�ndarinput.", "3. 1834. ", "3. Nej och Ja", "3. Moore's lag har fr�mst till�mpats inom bioteknik, vilket har lett till snabbare utveckling av mediciner och behandlingar f�r olika sjukdomar." };
        string[] arr3 = { "4. Datorprogram i form av ettor och treor.", "4. Ett program som skapar kalkulationer.", "4. Ett program som 3d skriver objekt.", "4. En utbildning om maskiner. ", "4. 1910", "4. G�r inte att svara p�", "4. Moore's lag �r en ekonomisk teori som f�ruts�ger att efterfr�gan p� datorer kommer att f�lja en exponentiell tillv�xttakt p� grund av �kad tillg�nglighet och s�nkta priser." };
        string[] questions = { "Vad betyder bin�r kod?", "Vad g�r en kompilator?", "Vad menas det med att ett spr�k �r objektorienterat?", "Vad menas med maskininl�rning?", "N�r skapades den f�rsta programmerbara datorn?", "Ta st�llning till f�ljande seriebild, �r exemplet utdaterat?", "Vilket av f�ljande val beskriver Moores lag?", "Kommer Moores lag att f�ljas i framtiden?", "F�rklara vad Open-source �r, redog�r f�r dess nackdelar och f�rdelar.", "Varf�r �r det viktigt att h�lla en konsekvent kodningstil?", "Varf�r beh�ver applikationer olika versioner f�r olika operativsystem?", "Hur har AI p�verkat programmerings m�jligheter och begr�nsningar?" , "Test done!" };

        public Form1()
        {
            currentQuestion = 0;
            InitializeComponent();
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
            currentQuestion++;
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
            checkBox1.Visible = true;            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            checkBox5.Visible = true;
            checkBox6.Visible = true;
            checkBox7.Visible = true;
            flowLayoutPanel2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentQuestion == 13)
            {
                textBox1.Visible = false;
                button2.Visible = false;
                question.Text = "Test done! Click on the results button to see your results.";
                button3.Visible = true;
            }
            else if (currentQuestion >= 8)
            {
                textBox1.Visible = true;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                question.Text = questions[currentQuestion -1];
                currentQuestion++;
                   
                
            }

            else
            {

                List<RadioButton> answers = flowLayoutPanel1.Controls.OfType<RadioButton>().ToList();
                for (int i = 0; i < answers.Count; i++)
                {
                    if (answers[i].Checked)
                    {
                        radioButton1.Text = arr[currentQuestion - 1];
                        radioButton2.Text = arr1[currentQuestion - 1];
                        radioButton3.Text = arr2[currentQuestion - 1];
                        radioButton4.Text = arr3[currentQuestion - 1];
                        question.Text = questions[currentQuestion - 1];
                        currentQuestion++;


                    } else if (currentQuestion == 7) {
                        pictureBox1.Visible = true;
                    }
                    else
                    {
                        pictureBox1.Visible = false;
                    } 
                }
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

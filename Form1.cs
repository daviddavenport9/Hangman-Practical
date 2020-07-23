using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_Practical
{
    public partial class Hangman : Form
    {
        public Hangman()
        {
            InitializeComponent();
            generateWords();
        }
        string[] wordList;
        int numAttempts = 0;
        string word;
        string hiddenWord;
        int letterIndex = 0;
        char charInput;


        public void generateWords()
        {
            //array created from random word generator
            wordList = new string[] {"fan", "meat", "sit", "discipline", "glove",
        "conglomerate", "scenario", "wing", "digital", "escape", "hockey", "computer", "empire",
         "redemption", "saber"};
        Random rand = new Random();
        int randomIndex = rand.Next(wordList.Length);
            //assigns the word a random index in the word list
            //word = wordList[randomIndex];
            word = "glove";
        hiddenWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                hiddenWord += '*';
            }
            Word.Text = hiddenWord;
        }

        private void btnLetterCheck_Click(object sender, EventArgs e)
        {
            if (letterCheck.Text != "" && letterCheck.Text.Length == 1)
            {
                //converts the value in letter check box to a char for comparison
                charInput = char.Parse(letterCheck.Text);
                letterIndex = 0;
                StringBuilder sb = new StringBuilder(hiddenWord);
                foreach (char c in word){
                    if (charInput == c)
                    {
                       //changes the * if letter matches user input
                        sb[letterIndex] = charInput;
                        hiddenWord = sb.ToString();
                        Word.Text = hiddenWord;
                    }
                    letterIndex++;
                }
                textUsedLetters.Text += charInput + " ";
                numAttempts++;
                lblAttemptNumber.Text = $"Number of Attempts: {numAttempts}";
                //if the user wins the game display new text
                if (hiddenWord == word)
                {
                    winnerLabel.Text = "You are a winner!";
                    letterCheck.ReadOnly = true;
                    btnLetterCheck.Enabled = false;
                }
            }
        }

        //displays the word if give upp button is pressed
        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            Word.Text = " ";
            Word.Text = word;
            winnerLabel.Text = "";
        }

        //resets the game after the user presses new game button
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            letterCheck.Text = "";
            Word.Text = "";
            generateWords();
            numAttempts = 0;
            lblAttemptNumber.Text = $"Number of Attempts: {numAttempts}";
            textUsedLetters.Text = "";
            letterCheck.ReadOnly = false;
            winnerLabel.Text = "";
            btnLetterCheck.Enabled = true;
        }
    }
}

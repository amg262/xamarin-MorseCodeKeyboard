using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MorseCodeKeyboard
{
    public partial class MainPage : ContentPage
    {
        private string sentence { get; set; }
        private string dotsAndDashes { get; set; }

        public MainPage() {
            // has to be here for each page
            InitializeComponent();
            sentence = "";
            dotsAndDashes = "";
        }

        void ButtonClicked(object sender, EventArgs args) {
            if (((Button)sender).Text == ".") {
                if (((Button)sender).ClassId == "dot") {
                    dotsAndDashes += ".";
                    outputMorseText.Text = dotsAndDashes;
                }
            } else if (((Button)sender).Text == "-") {
                if (((Button)sender).ClassId == "dash") {
                    dotsAndDashes += "-";
                    outputMorseText.Text += ".";
                }
            } else {
                if (((Button)sender).ClassId == "space") { 
                    outputText.Text += Morse.MorseCoder(dotsAndDashes);
                    dotsAndDashes = "";
                }
            }
            outputMorseText.Text = dotsAndDashes;
        }
    }
}

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Speech.Tts;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Lab_07.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(TextToSpeechImplementation))]
namespace Lab_07.Droid
{
    class TextToSpeechImplementation : Java.Lang.Object, ITextToSpeech, TextToSpeech.IOnInitListener
    {
        TextToSpeech speaker;
        string toSpeak;
        public void OnInit([GeneratedEnum] OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }

        public void Speak(string text)
        {
            toSpeak = text;
            if (speaker == null)
            {
                speaker = new TextToSpeech(Android.App.Application.Context, this);
            } else
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }
    }
}
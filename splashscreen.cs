using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Felipecsl.GifImageViewLib;

namespace Musiclious
{
    [Activity(Label = "splashscreen", MainLauncher=true)]
    public class splashscreen : Activity
    {
        private GifImageView gifImageView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.splashscreen);
            gifImageView = FindViewById<GifImageView>(Resource.Id.gifBackground);
            Stream Input = Assets.Open("background.gif");
            byte[] bytes = ConvertFileToByteArray(Input);
            gifImageView.SetBytes(bytes);
            gifImageView.StartAnimation();

            //wait 3 second start activity
            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.AutoReset = false;
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            StartActivity(new Intent(this, typeof(MainActivity)));
        }

        private byte[] ConvertFileToByteArray(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) < 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
    }
}
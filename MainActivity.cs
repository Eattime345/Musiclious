using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Felipecsl.GifImageViewLib;
using System.IO;
using System.Drawing;
using Android.Media;
using Stream = System.IO.Stream;
using System;
using Android.Views;

namespace Musiclious
{
    [Activity(Label = "@string/app_name" , MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main_page);
            ImageView ToMusicPlayer1 = FindViewById<ImageView>(Resource.Id.EdSheeran);
            ToMusicPlayer1.Click += OpenMusicPlayer;
            ImageView ToMusicPlayer2 = FindViewById<ImageView>(Resource.Id.Lauv);
            ToMusicPlayer2.Click += OpenMusicPlayer;
            ImageView ToMusicPlayer3 = FindViewById<ImageView>(Resource.Id.Bob);
            ToMusicPlayer3.Click += OpenMusicPlayer;
            ImageView ToMusicPlayer4 = FindViewById<ImageView>(Resource.Id.Jaz);
            ToMusicPlayer4.Click += OpenMusicPlayer;
            ImageView ToMusicPlayer5 = FindViewById<ImageView>(Resource.Id.Havana);
            ToMusicPlayer5.Click += OpenMusicPlayer;
            ImageView ToMusicPlayer6 = FindViewById<ImageView>(Resource.Id.Starboy);
            ToMusicPlayer6.Click += OpenMusicPlayer;
            ImageView ToMusicPlayer8 = FindViewById<ImageView>(Resource.Id.micheal);
            ToMusicPlayer8.Click += OpenMusicPlayer;
            ImageView ToMusicPlayer9 = FindViewById<ImageView>(Resource.Id.micheal_B);
            ToMusicPlayer9.Click += OpenMusicPlayer;
            ImageView ToMusicPlayer10 = FindViewById<ImageView>(Resource.Id.ariana);
            ToMusicPlayer10.Click += OpenMusicPlayer;
            ImageView ToMusicPlayer11 = FindViewById<ImageView>(Resource.Id.adele);
            ToMusicPlayer11.Click += OpenMusicPlayer;

        }

        private void OpenMusicPlayer(object sender, EventArgs e)
        {
            ImageView image = (ImageView)sender;
            Intent intent = new Intent(this, typeof(MusicPlayer));
            intent.PutExtra("Id", image.Id);
            StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            var inflater = MenuInflater;
            inflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Musiclious
{
    [Activity(Label = "MusicPlayer")]
    public class MusicPlayer : Activity
    {
        MediaPlayer mediaPlayer1;

        MediaPlayer mediaPlayer2;

        MediaPlayer mediaPlayer3;

        MediaPlayer mediaPlayer4;

        MediaPlayer mediaPlayer5;

        MediaPlayer mediaPlayer6;

        MediaPlayer mediaPlayer8;

        MediaPlayer mediaPlayer9;

        MediaPlayer mediaPlayer10;

        MediaPlayer mediaPlayer11;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Music_player);
            int id = Intent.Extras.GetInt("Id");
            mediaPlayer1 = MediaPlayer.Create(this, Resource.Raw.Perfect);
            mediaPlayer2 = MediaPlayer.Create(this, Resource.Raw.lauv);
            mediaPlayer3 = MediaPlayer.Create(this, Resource.Raw.BobMarley);
            mediaPlayer4 = MediaPlayer.Create(this, Resource.Raw.JazDariMata);
            mediaPlayer5 = MediaPlayer.Create(this, Resource.Raw.CamilaHavana);
            mediaPlayer6 = MediaPlayer.Create(this, Resource.Raw.starboy);
            mediaPlayer8 = MediaPlayer.Create(this, Resource.Raw.mj);
            mediaPlayer9 = MediaPlayer.Create(this, Resource.Raw.michealB);
            mediaPlayer10 = MediaPlayer.Create(this, Resource.Raw.ArianaDWomen);
            mediaPlayer11 = MediaPlayer.Create(this, Resource.Raw.adelleHello);
            ImageButton play = FindViewById<ImageButton>(Resource.Id.PlayButton);
            
            play.Click += delegate
            {
                switch (id)
                {
                    case Resource.Id.EdSheeran:
                        mediaPlayer1.Start();
                        break;
                    case Resource.Id.Lauv:
                        mediaPlayer2.Start();
                        break;
                    case Resource.Id.Bob:
                        mediaPlayer3.Start();
                        break;
                    case Resource.Id.Jaz:
                        mediaPlayer4.Start();
                        break;
                    case Resource.Id.Havana:
                        mediaPlayer5.Start();
                        break;
                    case Resource.Id.Starboy:
                        mediaPlayer6.Start();
                        break;
                    case Resource.Id.micheal:
                        mediaPlayer8.Start();
                        break;
                    case Resource.Id.micheal_B:
                        mediaPlayer9.Start();
                        break;
                    case Resource.Id.ariana:
                        mediaPlayer10.Start();
                        break;
                    case Resource.Id.adele:
                        mediaPlayer11.Start();
                        break;

                }
               
            };
        }
    }
}
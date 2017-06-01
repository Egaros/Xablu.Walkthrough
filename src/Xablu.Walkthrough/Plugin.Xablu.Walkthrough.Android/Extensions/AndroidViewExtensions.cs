﻿using System;
using Android.Widget;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Splat;

namespace Plugin.Xablu.Walkthrough.Extensions
{
    public static class AndroidViewExtensions
    {
        public static void SetValues<T>(this TextView textview, T control) where T : TextControl
        {
            textview.Text = control.Text;
            textview.TextSize = control.TextSize;
            textview.SetTextColor(control.TextColor.ToNative());

            switch (control.TextStyle)
            {
                case 1:
                    textview.SetTypeface(textview.Typeface, Android.Graphics.TypefaceStyle.Bold);
                    break;
                case 2:
                    textview.SetTypeface(textview.Typeface, Android.Graphics.TypefaceStyle.Italic);
                    break;
            }
        }

        public static void SetValues<T>(this ImageView imageView, T control) where T : ImageControl
        {
            var splatImage = BitmapLoader.Current.LoadFromResource(control.Image, null, null).Result;
            imageView.SetImageDrawable(splatImage.ToNative());
        }
    }
}

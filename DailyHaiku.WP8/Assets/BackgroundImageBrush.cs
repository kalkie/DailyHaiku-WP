﻿using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DailyHaiku.WP8.Assets
{
    public class BackgroundImageBrush
    {
        public ImageBrush GetBackground()
        {
            ImageBrush imageBrush = null;

            if ((Visibility)Application.Current.Resources["PhoneLightThemeVisibility"] == Visibility.Visible)
            { 
                imageBrush = new ImageBrush
                                 {
                                     ImageSource = new BitmapImage(new Uri("/Assets/Background_light.png", UriKind.Relative))
                                 };
            }
            else
            {
                imageBrush = new ImageBrush
                                 {
                                     ImageSource = new BitmapImage(new Uri("/Assets/Background.png", UriKind.Relative))
                                 };
            }

            return imageBrush;
        }
    }
}
﻿using System.Drawing;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;

namespace Plugin.Xablu.Walkthrough.Pages
{
    public class DefaultPage : IDefaultPage
    {
        public Color BackgroundColor { get; set; }
        public TextControl TitleControl { get; set; }
        public ImageControl ImageControl { get; set; }
        public TextControl DescriptionControl { get; set; }
    }
}
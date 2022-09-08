﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridCode : ContentPage
    {
        public GridCode()
        {
            InitializeComponent();
            Title = "Calculator - C#";
            BackgroundColor = Color.FromHex("#404040");

            var plainButton = new Style(typeof(Button))
            {
                Setters =
                {
                    new Setter { Property = Button.BackgroundColorProperty, Value = Color.FromHex("#eee") },
                    new Setter { Property = Button.TextColorProperty, Value = Color.Black },
                    new Setter { Property = Button.BorderRadiusProperty, Value = 0 },
                    new Setter { Property = Button.FontSizeProperty, Value = 40 }
                }
            };
            var darkerButton = new Style(typeof(Button))
            {
                Setters = 
                {
                    new Setter { Property = Button.BackgroundColorProperty, Value = Color.FromHex("#ddd") },
                    new Setter { Property = Button.TextColorProperty, Value = Color.Black },
                    new Setter { Property = Button.BorderRadiusProperty, Value = 0 },
                    new Setter { Property = Button.FontSizeProperty, Value = 40 }

                }
            };
            var orangeButton = new Style(typeof(Button))
            {
                Setters =
                {
                    new Setter { Property = Button.BackgroundColorProperty, Value = Color.FromHex("#E8AD00") },
                    new Setter { Property = Button.TextColorProperty, Value = Color.White },
                    new Setter { Property = Button.BorderRadiusProperty, Value = 0 },
                    new Setter { Property = Button.FontSizeProperty, Value = 40 }

                }
            };
            var controlGrid = new Grid { RowSpacing = 1, ColumnSpacing = 1};
            controlGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(150) });
            controlGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            controlGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            controlGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            controlGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            controlGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            controlGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            controlGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            controlGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            controlGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var label = new Label
            {
                Text = "0",
                HorizontalTextAlignment = TextAlignment.End,
                VerticalTextAlignment = TextAlignment.End,
                TextColor = Color.White,
                FontSize = 60
            };
            controlGrid.Children.Add(label, 0, 0);

            Grid.SetColumnSpan(label, 4);

            controlGrid.Children.Add(new Button { Text = "C",Style = darkerButton }, 0, 1);
            controlGrid.Children.Add(new Button { Text = "+/-", Style = darkerButton }, 1, 1);
            controlGrid.Children.Add(new Button { Text = "%", Style = darkerButton }, 2, 1);
            controlGrid.Children.Add(new Button { Text = "div", Style = darkerButton }, 3, 1);
            controlGrid.Children.Add(new Button { Text = "7", Style = darkerButton }, 0, 2);
            controlGrid.Children.Add(new Button { Text = "8", Style = darkerButton }, 1, 2);
            controlGrid.Children.Add(new Button { Text = "9", Style = darkerButton }, 2, 2);
            controlGrid.Children.Add(new Button { Text = "X", Style = darkerButton }, 3, 2);
            controlGrid.Children.Add(new Button { Text = "4", Style = darkerButton }, 0, 3);
            controlGrid.Children.Add(new Button { Text = "5", Style = darkerButton }, 1, 3);
            controlGrid.Children.Add(new Button { Text = "6", Style = darkerButton }, 2, 3);
            controlGrid.Children.Add(new Button { Text = "-", Style = darkerButton }, 3, 3);
            controlGrid.Children.Add(new Button { Text = "1", Style = darkerButton }, 0, 4);
            controlGrid.Children.Add(new Button { Text = "2", Style = darkerButton }, 1, 4);
            controlGrid.Children.Add(new Button { Text = "3", Style = darkerButton }, 2, 4);
            controlGrid.Children.Add(new Button { Text = "+", Style = darkerButton }, 3, 4);
            controlGrid.Children.Add(new Button { Text = ".", Style = darkerButton }, 2, 5);
            controlGrid.Children.Add(new Button { Text = "=", Style = darkerButton }, 3, 5);

            var zeroButton = new Button { Text = "0", Style = plainButton };
            controlGrid.Children.Add(zeroButton, 0, 5);
            Grid.SetColumnSpan(zeroButton, 2);

            Content = controlGrid;
        }
    }
}
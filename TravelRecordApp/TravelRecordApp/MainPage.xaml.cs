﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelRecordApp
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			var assembly = typeof(MainPage);

			iconImage.Source = ImageSource.FromResource("TravelRecordApp.Assets.Image.photo.jpg", assembly);
		}

		private void LoginButton_Clicked(object sender, EventArgs e)
		{
			bool isEmailEmpty = string.IsNullOrEmpty(emailEntry.Text);
			bool isPasswordEntry = string.IsNullOrEmpty(passwordEntry.Text);


			if (isEmailEmpty || isPasswordEntry)
			{

			}
			else
			{
				Navigation.PushAsync(new HomePage());
			}
		}
	}
}
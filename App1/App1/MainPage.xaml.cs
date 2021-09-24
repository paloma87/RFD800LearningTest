using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Com.Zebra.Rfid.Api3;
using System.Collections;
using System.Threading;

namespace App1
{
	public partial class MainPage : ContentPage
	{
		private ReaderModel rfidModel;

		public MainPage()
		{
			InitializeComponent();
			BindingContext = this;
			rfidModel = ReaderModel.readerModel;
		}
	}
}

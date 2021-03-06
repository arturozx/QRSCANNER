﻿using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using qrReaderForms.iOS;
using ZXing.Mobile;

[assembly: Dependency(typeof(QrCodeScanningService))]
namespace qrReaderForms.iOS
{
	public class QrCodeScanningService : IQrCodeScanningService
	{
		public async Task<ScanResult> Scan()
		{
			var scanner = new MobileBarcodeScanner()
			{
				UseCustomOverlay = false,
				BottomText = "El escaneo sera de forma automática",
				TopText = "Mantenga la camara \nal rededor de 15cm",
			};

			var result = await scanner.Scan();

			return new ScanResult
			{
				Text = result.Text,
			};
		}
	}
}


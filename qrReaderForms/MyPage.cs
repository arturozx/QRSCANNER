using System;

using Xamarin.Forms;

namespace qrReaderForms
{
	public class MyPage : ContentPage
	{
		public MyPage ()
		{
			Button btn = new Button{ Text = "qr" };
			Label lbl = new Label { Text = "Hello ContentPage" };
			IQrCodeScanningService scanner = DependencyService.Get<IQrCodeScanningService>();
			btn.Clicked += async (sender, args) => {

				var result = await scanner.Scan();

				lbl.Text = result.Text;
			};
			Content = new StackLayout { 
				Children = {
					btn,
					lbl

				}
			};
		}
	}
}



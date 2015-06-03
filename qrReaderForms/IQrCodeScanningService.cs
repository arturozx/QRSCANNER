using System;
using System.Threading.Tasks;

namespace qrReaderForms
{
	public interface IQrCodeScanningService
	{
		Task<ScanResult> Scan();
	}

	public class ScanResult
	{
		public string Text { get; set; }
	}
}


// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CryptoPriceTracker
{
	[Register ("CryptoPriceViewController")]
	partial class CryptoPriceViewController
	{
		[Outlet]
		UIKit.UILabel firstCurrencyLabel { get; set; }

		[Outlet]
		UIKit.UILabel priceLabel { get; set; }

		[Outlet]
		UIKit.UILabel secondCurrencyLabel { get; set; }

		[Action ("refreshTapped:")]
		partial void refreshTapped (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (priceLabel != null) {
				priceLabel.Dispose ();
				priceLabel = null;
			}

			if (firstCurrencyLabel != null) {
				firstCurrencyLabel.Dispose ();
				firstCurrencyLabel = null;
			}

			if (secondCurrencyLabel != null) {
				secondCurrencyLabel.Dispose ();
				secondCurrencyLabel = null;
			}
		}
	}
}

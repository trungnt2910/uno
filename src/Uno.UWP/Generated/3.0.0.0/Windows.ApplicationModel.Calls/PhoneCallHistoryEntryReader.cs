#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Calls
{
	#if false || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PhoneCallHistoryEntryReader 
	{
		#if false || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Calls.PhoneCallHistoryEntry>> ReadBatchAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<PhoneCallHistoryEntry>> PhoneCallHistoryEntryReader.ReadBatchAsync() is not implemented in Uno.");
		}
		#endif
	}
}

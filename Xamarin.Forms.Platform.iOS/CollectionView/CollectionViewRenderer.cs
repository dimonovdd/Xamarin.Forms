namespace Xamarin.Forms.Platform.iOS
{
	public class CollectionViewRenderer : GroupableItemsViewRenderer<GroupableItemsView, GroupableItemsViewController<GroupableItemsView>>
	{
		[Internals.Preserve(Conditional = true)]
		public CollectionViewRenderer() { }

		KeyboardInsetTracker _insetTracker;
		bool _disposed;

		public override void LayoutSubviews()
		{
			_insetTracker?.OnLayoutSubviews();
		}

		protected override void OnElementChanged(ElementChangedEventArgs<GroupableItemsView> e)
		{
			//if (e.NewElement != null)
			//{
			//	if (Control == null)
			//	{
			//		_insetTracker = new KeyboardInsetTracker(_tableViewController.TableView, () => Control.Window, insets => Control.ContentInset = Control.ScrollIndicatorInsets = insets, point =>
			//		{
			//			var offset = Control.ContentOffset;
			//			offset.Y += point.Y;
			//			Control.SetContentOffset(offset, true);
			//		}, this);
			//	}
			//}
			base.OnElementChanged(e);
		}

		protected override void Dispose(bool disposing)
		{
			if (_disposed)
				return;

			if (disposing)
			{
				if (_insetTracker != null)
				{
					_insetTracker.Dispose();
					_insetTracker = null;
				}
			}

			_disposed = true;

			base.Dispose(disposing);
		}
	}
}
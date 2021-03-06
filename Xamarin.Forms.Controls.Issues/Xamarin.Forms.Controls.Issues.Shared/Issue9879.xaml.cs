using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms.CustomAttributes;

namespace Xamarin.Forms.Controls.Issues
{
	[Issue(IssueTracker.Github, 9879, "CollectionView footer/header bug on iOS", PlatformAffected.iOS)]
	public partial class Issue9879 : TestContentPage
	{
		public Issue9879()
		{
#if APP
			InitializeComponent();
			TestCollection.ItemsSource = testItems;
#endif
		}

		List<string> testItems = new List<string>()
        {
            "item 1",
            "item 2",
            "item 3",
            "item 4",
            "item 5",
            "item 6",
            "item 7",
            "item 8",
            "item 9",
            "item 10",
		};

        protected override void Init()
		{
			
		}
	}
}
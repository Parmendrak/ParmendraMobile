using System.Collections.Generic;
using Xamarin.Forms;

namespace MobilePortal
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public MasterPage ()
		{
			InitializeComponent ();

			var masterPageItems = new List<MasterPageItem> ();
			masterPageItems.Add (new MasterPageItem {
				Title = "All Devices",
				IconSource = "contacts.png",
				TargetType = typeof(ContactsPage)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "Assigned By You",
				IconSource = "todo.png",
				TargetType = typeof(TodoListPage)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "Available",
				IconSource = "reminders.png",
				TargetType = typeof(ReminderPage)
			});

			listView.ItemsSource = masterPageItems;
		}
	}
}

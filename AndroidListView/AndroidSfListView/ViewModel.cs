using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AndroidSfListView
{
    class ViewModel
    {

        #region Properties

        public ObservableCollection<Contacts> contactsinfo { get; set; }

        #endregion

        #region Constructor

        public ViewModel()
        {
            contactsinfo = new ObservableCollection<Contacts>();
            Random r = new Random();
            for (int i = 0; i < 30; i++)
            {
                var contact = new Contacts();
                contact.ContactName = CustomerNames[r.Next(0, 4)];
                contact.ContactNumber = r.Next(720, 799).ToString() + " - " + r.Next(3010, 3999).ToString();
                contact.ContactColor = Color.FromRgb(r.Next(40, 255), r.Next(40, 255), r.Next(40, 255));
                contactsinfo.Add(contact);
            }
        }

        #endregion

        #region Fields

        public string[] CustomerNames = new string[] {
            "Ralph",
            "Torrey",
            "William",
            "Bill",
            "Daniel",
            "Frank",
            "Brenda",
            "Danielle",
            "Fiona",
            "Howard",
            "Jack",
            "Larry",
            "Holly",
            "Jennifer",
            "Liz",
            "Pete",
            "Steve",
    };
        #endregion
    }

}
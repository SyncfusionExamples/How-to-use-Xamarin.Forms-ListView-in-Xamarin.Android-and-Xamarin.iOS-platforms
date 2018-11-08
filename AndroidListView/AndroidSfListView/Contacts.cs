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
using System.ComponentModel;
using Xamarin.Forms;

namespace AndroidSfListView
{
    public class Contacts : INotifyPropertyChanged
    {
        private string contactName;
        private string contactNumber;
        private ImageSource image;
        private string displayString;
        private Color color;
        private Color textColor;


        public Contacts(string name, string number)
        {
            contactName = name;
            contactNumber = number;
            displayString = name[0].ToString();
        }

        public Contacts()
        {

        }

        public string ContactName
        {
            get { return contactName; }
            set
            {
                if (contactName != value)
                {
                    contactName = value;
                    this.RaisedOnPropertyChanged("ContactName");
                }
            }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (contactNumber != value)
                {
                    contactNumber = value;
                    this.RaisedOnPropertyChanged("ContactNumber");
                }
            }
        }

        public ImageSource ContactImage
        {
            get { return this.image; }
            set
            {
                this.image = value;
                this.RaisedOnPropertyChanged("ContactImage");
            }
        }

        public string DisplayString
        {
            get { return displayString; }
            set
            {
                if (displayString != value)
                {
                    displayString = value;
                    this.RaisedOnPropertyChanged("DisplayString");
                }
            }
        }

        public Color ContactColor
        {
            get { return color; }
            set
            {
                if (color != value)
                {
                    color = value;
                    this.RaisedOnPropertyChanged("ContactColor");
                }
            }

        }
        public Color TextColor
        {
            get { return textColor; }
            set
            {
                if (textColor != value)
                {
                    textColor = value;
                    this.RaisedOnPropertyChanged("TextColor");
                }
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }
    }
}
﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms.Controls.Gastropod.ViewModels
{
	[Preserve(AllMembers = true)]
	[QueryProperty("Payload", "payload")]
    public class CameraViewModel : INotifyPropertyChanged
    {
        private string _payload;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Payload
        {
            get { return _payload; }
            set
            {
                SetAndRaisePropertyChanged(ref _payload, value);
            }
        }

        protected void SetAndRaisePropertyChanged<TRef>(
            ref TRef field, TRef value, [CallerMemberName] string propertyName = null)
        {
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetAndRaisePropertyChangedIfDifferentValues<TRef>(
            ref TRef field, TRef value, [CallerMemberName] string propertyName = null)
            where TRef : class
        {
            if (field == null || !field.Equals(value))
            {
                SetAndRaisePropertyChanged(ref field, value, propertyName);
            }
        }
    }
}
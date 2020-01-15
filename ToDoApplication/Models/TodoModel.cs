using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ToDoApp.Models
{
	class TodoModel : INotifyPropertyChanged
	{
		private bool _isDone;
		private string _text;
		public DateTime CreationDate { get; set; } = DateTime.Now;
		public bool isDone
		{
			get { return _isDone; }
			set
			{
				if (_isDone == value)
					return;
				_isDone = value;
				OnPropertyChanged("isDone");
			}
		}

		public string Text
		{
			get { return _text; }
			set
			{
				if (_text == value)
					return;

				_text = value;
				OnPropertyChanged("Text");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

		}
	}
}
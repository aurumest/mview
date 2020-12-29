﻿using MView.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Input;
using System.Windows.Media;

namespace MView.Bases
{
    public class FileViewModelBase : PaneViewModelBase
    {
		#region ::Fields::

		private static ImageSourceConverter ISC = new ImageSourceConverter();

		private string _filePath = null;
		private string _textContent = string.Empty;
		private bool _isDirty = false;

		private RelayCommand _saveCommand = null;
		private RelayCommand _saveAsCommand = null;
		private RelayCommand _closeCommand = null;

		#endregion


		#region ::Constructors::

		/// <summary>
		/// Class constructor from file path.
		/// </summary>
		/// <param name="filePath"></param>
		public FileViewModelBase(string filePath)
		{
			FilePath = filePath;
			Title = FileName;
		}

		#endregion

		#region ::Properties::

		public string FilePath
		{
			get => _filePath;
			set
			{
				if (_filePath != value)
				{
					_filePath = value;
					RaisePropertyChanged(nameof(FilePath));
					RaisePropertyChanged(nameof(FileName));
					RaisePropertyChanged(nameof(Title));

					if (File.Exists(_filePath))
					{
						_textContent = File.ReadAllText(_filePath);
						ContentId = _filePath;
					}
				}
			}
		}

		public string FileName
		{
			get
			{
				if (FilePath == null)
					return "Untitled" + (IsDirty ? "*" : "");

				return Path.GetFileName(FilePath) + (IsDirty ? "*" : "");
			}
		}

		public bool IsDirty
		{
			get => _isDirty;
			set
			{
				if (_isDirty != value)
				{
					_isDirty = value;
					Title = FileName;
					RaisePropertyChanged(nameof(IsDirty));
					RaisePropertyChanged(nameof(FileName));
				}
			}
		}

		public ICommand SaveCommand
		{
			get
			{
				if (_saveCommand == null)
				{
					_saveCommand = new RelayCommand((p) => OnSave(p), (p) => CanSave(p));
				}

				return _saveCommand;
			}
		}

		public ICommand SaveAsCommand
		{
			get
			{
				if (_saveAsCommand == null)
				{
					_saveAsCommand = new RelayCommand((p) => OnSaveAs(p), (p) => CanSaveAs(p));
				}

				return _saveAsCommand;
			}
		}

		public ICommand CloseCommand
		{
			get
			{
				if (_closeCommand == null)
				{
					_closeCommand = new RelayCommand((p) => OnClose(), (p) => CanClose());
				}

				return _closeCommand;
			}
		}

		#endregion

		#region ::Methods::
		private bool CanClose()
		{
			return true;
		}

		private void OnClose()
		{
			Workspace.Instance.CloseFile(this);
		}

		private bool CanSave(object parameter)
		{
			return IsDirty;
		}

		private void OnSave(object parameter)
		{
			Workspace.Instance.SaveFile(this, false);
		}

		private bool CanSaveAs(object parameter)
		{
			return IsDirty;
		}

		private void OnSaveAs(object parameter)
		{
			Workspace.Instance.SaveFile(this, true);
		}

		#endregion
	}
}

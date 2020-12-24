﻿using MView.Bases;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Threading.Tasks;

namespace MView.ViewModels.Tool
{
    public class CryptographyManagerViewModel: ToolViewModelBase
    {
        #region ::Fields::

        public const string ToolContentId = "CryptographyManager";

		private string _selectedItemsString = "Selected Items(0)";

        #endregion

        #region ::Constructors::

        public CryptographyManagerViewModel() : base("Cryptography Manager")
        {
            ContentId = ToolContentId;

            Workspace.Instance.FileExplorer.SelectedNodes.CollectionChanged += new NotifyCollectionChangedEventHandler(OnCollectionChanged);
        }

		#endregion

		#region ::Properties::

		public string SelectedItemsString
        {
            get
            {
				return _selectedItemsString;
            }
            set
            {
                _selectedItemsString = value;
				RaisePropertyChanged();
            }
        }

		#endregion

		#region ::CollectionChanged Event Subscriber::

		private void OnCollectionChanged(object sender, EventArgs e)
		{
            SelectedItemsString = $"Selected Items({Workspace.Instance.FileExplorer.SelectedNodes.Count})";
        }

		#endregion
	}
}

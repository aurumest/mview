﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MView.ViewModels
{
    public class ViewerViewModel : PropertyChangedBase
    {
        private ExplorerViewModel Explorer { get; } = IoC.Get<ExplorerViewModel>();
    }
}

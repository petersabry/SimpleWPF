﻿using SimpleWPF.Core.Navigation;
using SimpleWPF.Core.ViewModels;

namespace SingleWindowSampleApplication.ViewModels
{
    public class AppViewModel : SimpleViewModel, ISimpleNavigationProvider
    {
        private SimpleViewModel current;

        public SimpleViewModel Current
        {
            get { return current; }
            set { OnPropertyChanged(ref current, value); }
        }

        private ISimpleWindow window;

        public ISimpleWindow Window
        {
            get { return window; }
            set { OnPropertyChanged(ref window, value); }
        }
    }
}
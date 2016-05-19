﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace PubnubWindowsPhone
{
    public sealed partial class ChangeUUIDUserControl : UserControl
    {
        public bool IsCancelledButton = false;

        public ChangeUUIDUserControl()
        {
            this.InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            IsCancelledButton = true;
            ClosePopupWindow();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            IsCancelledButton = false;
            ClosePopupWindow();
        }

        private void ClosePopupWindow()
        {
            StackPanel sp = this.Parent as StackPanel;
            if (sp != null)
            {
                Border b = sp.Parent as Border;
                if (b != null)
                {
                    Popup popup = b.Parent as Popup;
                    popup.IsOpen = false;
                }
            }
        }

    }
}
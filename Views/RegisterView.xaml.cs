﻿using ModernWpf.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GoninDigital.Views
{
    /// <summary>
    /// Interaction logic for RegisterView.xaml
    /// </summary>
    public partial class RegisterView : UserControl
    {
        public RegisterView()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (FloatingPasswordBox.Password != FloatingrePasswordBox.Password)
            {
                FloatingPasswordBox.Password = null;
                FloatingrePasswordBox.Password = null;
                ContentDialog content = new()
                {
                    Title = "Warning",
                    Content = "Your Password not match, Pleace try again!",
                    PrimaryButtonText = "Ok"
                };
                content.ShowAsync();
            }
        }
    }
}

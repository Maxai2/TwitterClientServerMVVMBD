﻿using System;
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
using TwitterClientServerMVVMBD.Interface;

namespace TwitterClientServerMVVMBD.View
{
    public partial class MainWindow : Window, IMainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void BindDataContext(IMainWindowViewModel context)
        {
            DataContext = context;
        }

        public void ShowAlert(string text, string caption)
        {
            MessageBox.Show(text, caption);
        }
    }
}

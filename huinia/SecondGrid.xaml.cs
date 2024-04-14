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
using huinia.ITCompanDataSetTableAdapters;

namespace huinia
{

    /// Логика взаимодействия для SecondGrid.xaml

    public partial class SecondGrid : Page
    {
        ProjectsTableAdapter Projects = new ProjectsTableAdapter();

        public SecondGrid()
        {
            InitializeComponent();
            ProjectsDataGrid.ItemsSource = Projects.GetData();
        }
    }
}
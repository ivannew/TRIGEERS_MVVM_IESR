﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRIGEERS_MVVM_IESR.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TRIGEERS_MVVM_IESR.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Categoria : ContentPage
    {
        public Categoria()
        {
            InitializeComponent();
            BindingContext = new VMcategoria(Navigation);
        }
    }
}
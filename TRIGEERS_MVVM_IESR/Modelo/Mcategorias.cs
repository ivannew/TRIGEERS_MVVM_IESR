using System;
using System.Collections.Generic;
using System.Text;
using TRIGEERS_MVVM_IESR;

namespace TRIGEERS_MVVM_IESR.Modelo
{
    public class Mcategorias : BaseViewModel
    {
        public string descripcion { get; set; }
        public int numeroItem { get; set; }
        public string imagen { get; set; }
        public string _backgroudColor;
        public string _textColor;
        public bool _selected;

        public string backgroundColor
        {
            get { return _backgroudColor; }
            set { SetProperty(ref _backgroudColor, value); }
        }
        public string textColor
        {
            get { return _textColor; }
            set { SetProperty(ref _textColor, value); }
        }
        public bool selected
        {
            get { return _selected; }
            set { SetProperty(ref _selected, value); }
        }


    }
}
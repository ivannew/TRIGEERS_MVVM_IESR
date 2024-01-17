using System;
using System.Collections.Generic;
using System.Text;
using TRIGEERS_MVVM_IESR;

namespace TRIGEERS_MVVM_IESR.Modelo
{
    public class Mcategorias: BaseViewModel
    {
        public string descripcion { get; set; }
        public int numeroItem { get; set; }
        public string imagen { get; set; }
        public string _backgroudColor;
        public string _textColor;
        public bool _selectd;

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
        public bool selectd
        {
            get { return _selectd; }
            set { SetProperty(ref _selectd, value); }
        }

    }
}

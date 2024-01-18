using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TRIGEERS_MVVM_IESR.Modelo;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace TRIGEERS_MVVM_IESR.VistaModelo
{
    public class VMcategoria : BaseViewModel
    {
        string _Texto;
        bool _activadorAnimacionImg;
        string _imagen;
        ObservableCollection<Mcategorias> _listaCategorias;

        public VMcategoria(INavigation navigation)
        {
            Navigation = navigation;
            MostrarCategoria();
        }


        public ObservableCollection<Mcategorias> ListaCategorias
        {
            get { return _listaCategorias; }
            set { SetProperty(ref _listaCategorias, value); }
        }
     
         public bool ActivardorAnimacionImg
        {
            get { return _activadorAnimacionImg; }
            set { SetProperty(ref _activadorAnimacionImg, value); }
        }
        public string imagen
        {
            get { return _imagen; }
            set { SetProperty(ref _imagen, value); }
        }

        public void seleccionar(Mcategorias modelo)
        {
            var index = ListaCategorias
                .ToList()
                .FindIndex(p => p.descripcion == modelo.descripcion);

            imagen = modelo.imagen;
            if(index>-1)
            {
                Deseleccionar();
                _activadorAnimacionImg = true;
                ListaCategorias[index].selected = true;
                ListaCategorias[index].textColor = "#ffffff";
                ListaCategorias[index].backgroundColor = "#FF506b";
            }
            

        }
        public void Deseleccionar()
        {
            ListaCategorias.ForEach((item) =>
            {
                ActivardorAnimacionImg = false;
                item.selected = false;
                item.textColor = "#000000";
                item.backgroundColor = "#EAEDF6";

            });
        }

        public async Task ProcesoAsyncrono()
        {

        }

        public void MostrarCategoria()
        {
            _listaCategorias = new ObservableCollection<Mcategorias>(Datos.Dcategorias.MostrarCategorias());
          
        }


        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcomand => new Command(MostrarCategoria);

    }
}

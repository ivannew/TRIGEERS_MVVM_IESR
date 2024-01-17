using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TRIGEERS_MVVM_IESR.Modelo;

namespace TRIGEERS_MVVM_IESR.Datos
{
    public class Dcategorias
    {
        public static ObservableCollection<Mcategorias> MostrarCategorias()
        {
            return new ObservableCollection<Mcategorias>()
            {
                new Mcategorias()
                {
                    descripcion="cena",
                    numeroItem=4512,
                    imagen="",
                    backgroundColor="#EAEDF6",
                    textColor="#00000"
                },
                new Mcategorias()
                {
                    descripcion="fiesta",
                    numeroItem=4512,
                    imagen="",
                    backgroundColor="#EAEDF6",
                    textColor="#00000"
                },
                new Mcategorias()
                {
                    descripcion="cena",
                    numeroItem=4512,
                    imagen="",
                    backgroundColor="#EAEDF6",
                    textColor="#00000"
                },
                new Mcategorias()
                {
                    descripcion="cena",
                    numeroItem=4512,
                    imagen="",
                    backgroundColor="#EAEDF6",
                    textColor="#00000"
                }
            };
        }
    }
}

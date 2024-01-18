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
                    /*<a href="https://imgbb.com/"><img src="https://i.ibb.co/nR3x3VR/superheroe.png" alt="superheroe" border="0"></a>
<a href="https://imgbb.com/"><img src="https://i.ibb.co/DkGnbpq/leon.png" alt="leon" border="0"></a>
<a href="https://imgbb.com/"><img src="https://i.ibb.co/rxtcLSL/gato.png" alt="gato" border="0"></a>
<a href="https://imgbb.com/"><img src="https://i.ibb.co/mThzYYy/perro.png" alt="perro" border="0"></a>*/
                    descripcion="pantera",
                    numeroItem=4512,
                    imagen="https://i.ibb.co/nR3x3VR/superheroe.png",
                    backgroundColor="#000000",
                    textColor="#ffffff"
                },
                new Mcategorias()
                {
                    descripcion="leon",
                    numeroItem=4512,
                    imagen="https://i.ibb.co/DkGnbpq/leon.png",
                    backgroundColor="#000000",
                    textColor="#ffffff"

                },
                new Mcategorias()
                {
                    descripcion="perro",
                    numeroItem=4512,
                    imagen="https://i.ibb.co/mThzYYy/perro.png",
                    backgroundColor="#000000",
                    textColor="#ffffff"
                },
                new Mcategorias()
                {
                    descripcion="gato",
                    numeroItem=4512,
                    imagen="https://i.ibb.co/rxtcLSL/gato.png",
                    backgroundColor="#000000",
                    textColor="#ffffff"
                }
            };
        }
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenMvvm.ViewModels
{
    public partial class DescuentoCompra : ObservableObject
    {
        [ObservableProperty]
        private double producto1;

        [ObservableProperty]
        private double producto2;

        [ObservableProperty]
        private double producto3;

        [ObservableProperty]
        private double subtotal;

        [ObservableProperty]
        private double descuento;

        [ObservableProperty]
        private double totalapagar;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]

        private void Calcular()
        {

            try
            {
                if (producto1<0 || producto2<0 || producto3<0)
                {
                    Alerta("ADVERTENCIA", "Valor de la compra del producto no puede ser negativo");

                }else if (producto1 == 0 || producto2 == 0 || producto3 == 0)
                {
                    Alerta("ADVERTENCIA", "Valor de la compra del producto no puede ser cero");

                }else
                {
                    subtotal = producto1 + producto2 + producto3;

                    if (subtotal <= 999.99)
                    {
                        descuento = 0;

                    }else if (subtotal >= 1000 & subtotal <= 4999.99)
                    {
                        descuento = subtotal * 0.10;
                    }
                    else if (subtotal >= 5000 & subtotal <= 9999.99)
                    {
                        descuento = subtotal * 0.20;
                    }
                    else if (subtotal >= 10000)
                    {
                        descuento = subtotal * 0.30;
                    }

                }



            }
            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message);
            }


        }

        [RelayCommand]
        private void Limpiar()
        {
            Producto1 = 0;
            Producto2 = 0;
            Producto3 = 0;
            Subtotal = 0;
            Descuento = 0;          
            Totalapagar = 0;

        }




    }
}

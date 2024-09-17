using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenMvvm.ViewModels
{
    public partial class DescuentoCompraViewModel : ObservableObject
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
                if (Producto1 < 0 || Producto2 < 0 || Producto3 < 0)
                {
                    Alerta("ADVERTENCIA", "Valor de la compra del producto no puede ser negativo");

                }
                else if (Producto1 == 0 || Producto2 == 0 || Producto3 == 0)
                {
                    Alerta("ADVERTENCIA", "Valor de la compra del producto no puede ser cero");

                }
                else
                {
                    Subtotal = Producto1 + Producto2 + Producto3;

                    if (Subtotal <= 999.99)
                    {
                        Descuento = 0;

                    }
                    else if (Subtotal >= 1000 && Subtotal <= 4999.99)
                    {
                        Descuento = Subtotal * 0.10;
                    }
                    else if (Subtotal >= 5000 && Subtotal <= 9999.99)
                    {
                        Descuento = Subtotal * 0.20;
                    }
                    else if (Subtotal >= 10000)
                    {
                        Descuento = Subtotal * 0.30;
                    }

                    Totalapagar = Subtotal - Descuento;

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

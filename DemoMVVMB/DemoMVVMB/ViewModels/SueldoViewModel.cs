using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoMVVMB.ViewModels
{
    public class SueldoViewModel : ViewModelBase
    {
        
            //public int Sueldo { get; set; }
            //public int Gratificacion { get; set; }    
            //public int SueldoNeto { get; set; }
            int sueldo;
            public int Sueldo
            {
                get { return sueldo; }
                set
                {
                    if (sueldo != value)
                    {
                        sueldo = value;
                        OnPropertyChanged();
                    }
                }
            }
            int gratificacion;
            public int Gratificacion
            {
                get { return gratificacion; }
                set
                {
                    if (gratificacion != value)
                    {
                        gratificacion = value;
                        OnPropertyChanged();
                    }
                }
            }
            double sueldoNeto;
            public double SueldoNeto
            {
                get { return sueldoNeto; }
                set
                {
                    if (sueldoNeto != value)
                    {
                        sueldoNeto = value;
                        OnPropertyChanged();
                    }
                }
            }

            double descuento;
            public double Descuento
            {
                get { return descuento; }
                set
                {
                    if (descuento != value)
                    {
                        descuento = value;
                        OnPropertyChanged();
                    }
                }
            }

            double respuesta;
            public double Respuesta
            {
                get { return respuesta; }
                set
                {
                    if (respuesta != value)
                    {
                        respuesta = value;
                        OnPropertyChanged();
                    }
                }
            }

            double impuesto;
            public double Impuesto
            {
                get { return impuesto; }
                set
                {
                    if (impuesto != value)
                    {
                        impuesto = value;
                        OnPropertyChanged();
                    }
                }
            }

            public ICommand CalcularSueldoNeto { protected set; get; }
            public ICommand CalcularNetoFinal { protected set; get; }

            public ICommand CalcularImpuesto { protected set; get; }

            public SueldoViewModel()
            {
                CalcularSueldoNeto = new Command(() =>
                {
                    SueldoNeto = Sueldo + Gratificacion;
                });

                CalcularNetoFinal = new Command(() =>
                {
                    SueldoNeto = Sueldo + Gratificacion;
                    Respuesta = SueldoNeto - descuento;
                });
                CalcularImpuesto = new Command(() =>
                {
                    SueldoNeto = Sueldo + Gratificacion;
                    Impuesto = SueldoNeto * 0.08;
                });

            }




        }
    
}

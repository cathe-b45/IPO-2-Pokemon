using ControlDeUsuarioPokemon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace ProyectoUWPenBlanco
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void cambiarVida(object sender, RangeBaseValueChangedEventArgs e)
        {
            this.Mimikyu.Vida = e.NewValue;
        }

        private void cambiarEnergía(object sender, RangeBaseValueChangedEventArgs e)
        {
            this.Mimikyu.energia = e.NewValue;
        }

        private void EjecutarAtaqueFuerte(object sender, RoutedEventArgs e)
        {
            Mimikyu.animacionAtaqueFuerte();
        }

        private void EjecutarAtaqueFlojo(object sender, RoutedEventArgs e)
        {
            Mimikyu.animacionAtaqueFlojo();
        }

        private void EjecutarDefensa(object sender, RoutedEventArgs e)
        {
            Mimikyu.animacionDefensa();
        }

        private void EjecutarDescansar(object sender, RoutedEventArgs e)
        {
            Mimikyu.animacionDescasar();
        }

        private void activarIddle(object sender, RoutedEventArgs e)
        {
            Mimikyu.activarAniIdle(true);
        }

        private void desactivarIddle(object sender, RoutedEventArgs e)
        {
            Mimikyu.activarAniIdle(false);
        }

        private void desactivarCansado(object sender, RoutedEventArgs e)
        {
            Mimikyu.animacionNoCansado();
        }

        private void activarCansado(object sender, RoutedEventArgs e)
        {
            Mimikyu.animacionCansado();
        }

        private void activarHerido(object sender, RoutedEventArgs e)
        {
            Mimikyu.animacionHerido();
        }

        private void desactivarHerido(object sender, RoutedEventArgs e)
        {
            Mimikyu.animacionNoHerido();
        }

        private void desactivarEscudo(object sender, RoutedEventArgs e)
        {
            Mimikyu.verEscudo(false);
        }

        private void activarEscudo(object sender, RoutedEventArgs e)
        {
            Mimikyu.verEscudo(true);
        }

        private void verFondo(object sender, RoutedEventArgs e)
        {
            Mimikyu.verFondo(true);
        }

        private void noVerFondo(object sender, RoutedEventArgs e)
        {
            Mimikyu.verFondo(false);
        }

        private void noVerFilaVida(object sender, RoutedEventArgs e)
        {
            Mimikyu.verFilaVida(false);
        }

        private void verFilaVida(object sender, RoutedEventArgs e)
        {
            Mimikyu.verFilaVida(true);
        }

        private void verFilaEnergia(object sender, RoutedEventArgs e)
        {
            Mimikyu.verFilaEnergia(true);
        }

        private void noVerFilaEnergía(object sender, RoutedEventArgs e)
        {
            Mimikyu.verFilaEnergia(false);
        }

        private void verPocimaVida(object sender, RoutedEventArgs e)
        {
            Mimikyu.verPocionVida(true);
        }

        private void noVerPocimaVida(object sender, RoutedEventArgs e)
        {
            Mimikyu.verPocionVida(false);
        }

        private void noVerPocimaEnergia(object sender, RoutedEventArgs e)
        {
            Mimikyu.verPocionEnergia(false);
        }

        private void verPocimaEnergia(object sender, RoutedEventArgs e)
        {
            Mimikyu.verPocionEnergia(true);
        }

        private void verNombrePokemon(object sender, RoutedEventArgs e)
        {
            Mimikyu.verNombre(true);
        }

        private void noVerNombrePokemon(object sender, RoutedEventArgs e)
        {
            Mimikyu.verNombre(false);
        }
    }
}

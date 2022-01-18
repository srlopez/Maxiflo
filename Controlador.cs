using System;
using System.Collections.Generic;
using System.Linq;
using Maxiflo;

namespace Maxiflo.UI.Consola
{
    class Controlador
    {
        private Vista _vista;

        private Sistema _sistema;
        private Dictionary<string, Action> _casosDeUso;
        public Controlador(Vista vista, Sistema businessLogic)
        {
            _vista = vista;
            _sistema = businessLogic;
            _casosDeUso = new Dictionary<string, Action>(){
                { "Sumar fracciones", Sumar },
                { "Restar", Restar },
            };
        }

        // === Ciclo de la Aplicacin ===
        public void Run()
        {
            _vista.LimpiarPantalla();
            // Acceso a las Claves del diccionario
            var menu = _casosDeUso.Keys.ToList<String>();

            while (true)
                try
                {
                    //Limpiamos
                    _vista.LimpiarPantalla();
                    // Menu
                    var key = _vista.TryObtenerElementoDeLista("Menu de Usuario", menu, "Seleciona una opción");
                    _vista.Mostrar("");
                    // Ejecución de la opción escogida
                    _casosDeUso[key].Invoke();
                    // Fin
                    _vista.MostrarYReturn("Pulsa <Return> para continuar");
                }
                catch { return; }
        }
        // === Casos De Uso ===

        void Sumar(){
            try{
            var n1 = _vista.TryObtenerDatoDeTipo<int>("dame el n1");
            var d1 = _vista.TryObtenerDatoDeTipo<int>("dame el d1");
            var n2 = _vista.TryObtenerDatoDeTipo<int>("dame el n2");
            var d2 = _vista.TryObtenerDatoDeTipo<int>("dame el d2");
            Fraccion frac1=new Fraccion(n1,d1);
            Fraccion frac2=new Fraccion(n2,d2);
            var suma = _sistema.Sumar(frac1,frac2);
            _vista.Mostrar(suma);
            }
            catch{
                _vista.Mostrar("Casode uso abortao");
            }
            

        }

        void Restar(){

        }
    }
}

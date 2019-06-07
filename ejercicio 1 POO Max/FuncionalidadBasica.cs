using System;

namespace ejercicio_1_POO_Max{
    public interface IBasic{
        string Modelo { get; set; }
        bool agenda();
        void Mensajes();
        void Llamar();
            
    }
}
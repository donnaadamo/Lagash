using system;

namespace ejercicio_1_POO_Max{

    class Smartphone : IBasic{

        public int store;
        public int camara;

        public string Modelo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool agenda()
        {
            throw new NotImplementedException();
        }

        public void Llamar()
        {
            throw new NotImplementedException();
        }

        public void Mensajes()
        {
            throw new NotImplementedException();
        }
    }
}
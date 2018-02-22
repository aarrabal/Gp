using System;

namespace GestionPolicial.Domain.Factorias
{
    public class Factoria<T>
    {
        public static T Get()
        {
            return (T)Activator.CreateInstance(typeof(T)); ;

        }
    }
}
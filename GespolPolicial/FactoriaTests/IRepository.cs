﻿using System;
using System.Linq.Expressions;

namespace GespolPolicial.Test.FactoriaTests
{
    public interface IRepository<T> : IDisposable where T : class
    {
        ///
        /// Encuentra un objeto por la expresión indicada
        ///
        ///
        T Find(Expression<Func<T, bool>> predicate);

        ///
        /// Crea un nuevo objeto en la base de datos
        ///
        ///Nuevo objeto a crear
        T Create(T t);

        ///
        /// Borra objetos de la base de datos en base a una expresión de filtrado
        ///
        ///
        int Delete(Expression<Func<T, bool>> predicate);

        ///
        /// Actualiza los cambios del objeto en la base de datos
        ///
        ///Objeto a actualizar
        bool Update(T t);
    }
}
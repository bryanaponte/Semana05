using Data;
using Entity;
using System;
using System.Collections.Generic;

namespace Business
{
    public class BCategoria
    {
        private DCategoria DCategoria = null;

        public List<Categoria> Listar(int IdCategoria)
        {
            List<Categoria> categorias = null;
            try
            {
                DCategoria = new DCategoria();
                categorias = DCategoria.Listar(new Categoria { IdCategoria = IdCategoria });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return categorias;
        }

        public bool Insertar(Categoria categoria)
        {
            bool result = true;
            try
            {
                DCategoria = new DCategoria();
                DCategoria.Insertar(categoria);
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                result = false;
            }
            return result;
        }

        public bool Actualizar(Categoria categoria)
        {
            bool result = true;
            try
            {
                DCategoria = new DCategoria();
                DCategoria.Actualizar(categoria);
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                result = false;
            }
            return result;
        }

        public bool Eliminar(int IdCategoria)
        {
            bool result = true;
            try
            {
                DCategoria = new DCategoria();
                DCategoria.Eliminar(IdCategoria);

            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                result = false;
            }
            return result;
        }
    }
}

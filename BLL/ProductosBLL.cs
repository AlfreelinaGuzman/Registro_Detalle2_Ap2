using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Registro_Detalle2_Ap2.DAL;
using Registro_Detalle2_Ap2.Models;

namespace Registro_Detalle2_Ap2.BLL
{
    public class ProductosBLL
    {
        public static bool Guardar(Productos producto)
        {
            if (!Existe(producto.ProductoId))
                return Insertar(producto);
            else
                return Modificar(producto);
        }

        /*++++++++++++++++++++++++++++++++   EXISTE   ++++++++++++++++++++++++++++++++*/
        private static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Productos.Any(d => d.ProductoId == id);
            } 
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

        /*++++++++++++++++++++++++++++++++   INSERTAR   ++++++++++++++++++++++++++++++++*/
        private static bool Insertar(Productos productos)
        {
            Contexto contexto = new Contexto();
            bool insertado = false;

            try
            {
                contexto.Productos.Add(productos);
                insertado = (contexto.SaveChanges() > 0);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return insertado;
        }

        /*++++++++++++++++++++++++++++++++   MODIFICAR   ++++++++++++++++++++++++++++++++*/
        private static bool Modificar(Productos productos)
        {
            Contexto contexto = new Contexto();
            bool modificado = false;

            try
            {
                contexto.Entry(productos).State = EntityState.Modified;
                modificado = (contexto.SaveChanges() > 0);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return modificado;
        }

        /*++++++++++++++++++++++++++++++++   ELIMINAR   ++++++++++++++++++++++++++++++++*/
        public static bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool eliminado = false;

            try
            {
                var buscando = contexto.Productos.Find(id);
                contexto.Entry(buscando).State = EntityState.Deleted;
                eliminado = (contexto.SaveChanges() > 0);
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return eliminado;
        }

        /*++++++++++++++++++++++++++++++++   BUSCAR   ++++++++++++++++++++++++++++++++*/
        public static Productos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Productos productos = new Productos();

            try
            {
                productos = contexto.Productos.Find(id);
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return productos;
        }

        /*++++++++++++++++++++++++++++++++   LISTAR  ++++++++++++++++++++++++++++++++*/
        public static List<Productos> GetList(Expression<Func<Productos, bool>> productos)
        {
            Contexto contexto = new Contexto();
            List<Productos> listado = new List<Productos>();

            try
            {
                listado = contexto.Productos.Where(productos).ToList();
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return listado;
        }

    }
}
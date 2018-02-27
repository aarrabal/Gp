using System;
using System.Data.Entity.Validation;
using System.Linq;
using GestionPolicial.Dal.EF;
using GestionPolicial.Domain.Model;
using GestionPolicial.Domain.Model.Documentos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.EF
{
    /// <summary>
    /// Descripción resumida de GpContextTest
    /// </summary>
    [TestClass]
    public class GpContextTest
    {


        [TestMethod]
        public void TestContext()
        {
            var target = new GpContext();
            {
                try
                {
                    // Your code...
                    // Could also be before try if you know the exception occurs in SaveChanges


                    /* var persona = new Persona();
                     persona.FechaNacimiento = new DateTime();
                     */
                    var persona = new Persona {FechaNacimiento = new DateTime(2000, 09, 01)};
                    target.Personas.Add(persona);
                    target.SaveChanges();

                    var policia = new Policia {NumeroPlaca = 5};
                    target.Policias.Add(policia);
                    target.SaveChanges();

                    var detenido = new Detenido {FechaDetencion = new DateTime(2000, 02, 01)};
                    target.Detenidos.Add(detenido);
                    target.SaveChanges();

                    var usuario = new Usuario();
                    target.Usuarios.Add(usuario);
                    target.SaveChanges();

                    var dni = new Dni() {NumeroDocumento = "56904819"};
                    target.Dnis.Add(dni);
                    target.SaveChanges();

                    var nie = new Nie() {NumeroDocumento = "Z5164919K"};
                    target.Nies.Add(nie);
                    target.SaveChanges();

                    var pasaporte = new Pasaporte() {NumeroDocumento = "C35890664"};
                    target.Pasaportes.Add(pasaporte);
                    target.SaveChanges();

                    var policias = target.Policias.Count();
                    var policias2 = target.Personas.OfType<Policia>().Count();
                }
              
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine(
                            "Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                }
                catch (Exception ex)
                {


                }
            }
        }
    }
}

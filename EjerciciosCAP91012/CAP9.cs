using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosCAP91012
{
    class Cap9_1_3_4
    {

        //EJERCICIO 1
        public struct ArticulosMercado
        {
            int ProductID;
            string NomProduc;
            float PrecioProduc;
            float CantDisponible;

             
            public ArticulosMercado(int id, string nombreP, float Precio, float CantD)
            {
                
                ProductID = id;
                NomProduc = nombreP;
                PrecioProduc = Precio;
                CantDisponible = CantD;
            }


            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Id: {0}\nNombre del producto: {1}\nPrecio del Producto: {2}\nCantidad disponible: {3}\n", ProductID, NomProduc, PrecioProduc, CantDisponible);
                return (sb.ToString());
            }
        }


        public void NueveUno()
        {
            Console.WriteLine("PRODUCTOS DISPONIBLES EN EL MERCADO:\n");
            ArticulosMercado pt = new ArticulosMercado(1, "Naranjas", 180f, 25f);
            ArticulosMercado p = new ArticulosMercado(2, "Pollo", 90f, 53f);
            Console.WriteLine(pt.ToString());
            Console.WriteLine(p.ToString());
        }





        //EJERCICIO 3
        public struct Mascota
        {
            public string NombreMascota;
            string TipoMascota;
            int EdadMascota;
            string GeneroMascota;


            public Mascota(string nombreM, string tipoM, int edadM, string generoM)
            {

                NombreMascota = nombreM;
                TipoMascota = tipoM;
                EdadMascota = edadM;
                GeneroMascota = generoM;
            }


            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("\nInformación de la Mascota: \nNombre: {0} \nTipo de Animal: {1} \nDe edad: {2} años \nDe genero: {3}\n", NombreMascota, TipoMascota, EdadMascota, GeneroMascota);
                return (sb.ToString());
            }
        }


        public struct Persona
        {
            string Nombre;
            int Edad;
            string Genero;
            Mascota mascota;


            public Persona(string nombre, int edad, string genero, string nombreM, string tipoM, int edadM, string generoM)
            {

                Nombre = nombre;
                Edad = edad;
                Genero = genero;


                mascota = new Mascota(nombreM, tipoM, edadM, generoM);
            }


            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("\nNombre: {0}\nEdad: {1} años\nGénero: {2}\n", Nombre, Edad, Genero);

                sb.Append(mascota.ToString());
                return (sb.ToString());
            }
        }


        public void DuenoMascota()
        {
            Console.WriteLine("DUEÑOS Y SUS MASCOTAS:\n");
            Persona p = new Persona("Victor", 20, "Hombre", "Enzo", "Perro raza Blue nose Pitbull", 2, "Macho");
            Console.WriteLine(p.ToString());
            Persona p1 = new Persona("María", 40, "Mujer", "Fifi", "Gato", 3, "Hembra");
            Console.WriteLine(p1.ToString());
        }




        //EJERCICIO 4
        enum TiposNeumaticos
        {

            NeumaticosDeVerano = 1, NeumaticosDeInvierno, NeumaticosAllSeasons, NeumaticosCoche,
            NeumaticosFurgoneta, Neumaticos4x4, NeumaticosPerfilBajo, NeumaticosPerfilAlto,
            NeumaticosRunflat, NeumaticosTubuless, NeumaticosRecauchados, NeumaticosVerdes,
            NeumaticosRadiales, NeumaticosDiagonales
        };

        public void Ruedas()
        {
            TiposNeumaticos neumatico;
            neumatico = TiposNeumaticos.NeumaticosCoche;
            Console.WriteLine("Neumático Usado: {0}", neumatico);
        }
    }
}

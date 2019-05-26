using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosCAP91012
{
    class CAP10ALL
    {
        //EJERCICIO 1

        public class InventarioTienda
        {

            private float CantVendida;
            private float PrecioVendido;
            private float GastosArticulos;
            private float ImpuestoArt;


            public InventarioTienda()
            {

                CantVendida = 0;
                PrecioVendido = 0;
                GastosArticulos = 0;
                ImpuestoArt = 0;
            }


            public float GetCantVendida()
            {
                return CantVendida;
            }
            public void SetCantVendida(float CantVendida)
            {
                this.CantVendida = CantVendida;
            }


            public float GetPrecioVendido()
            {
                return PrecioVendido;
            }
            public void SetPrecioVendido(float PrecioVendido)
            {
                this.PrecioVendido = PrecioVendido;
            }


            public float GetGastosArticulos()
            {
                return GastosArticulos;
            }
            public void SetGastosArticulos(float GastosArticulos)
            {
                this.GastosArticulos = GastosArticulos;
            }

            public float GetImpuestoArt()
            {
                return ImpuestoArt;
            }
            public void SetImpuestoArt(float impuestoArt)
            {
                this.ImpuestoArt = impuestoArt;
            }

            public float Inventario()
            {
                float ganancias = 0;
                ganancias = (CantVendida * PrecioVendido) - (GastosArticulos + ImpuestoArt);
                return ganancias;
            }
        }


        //EJERCICIO 2

        public class EstudiantesColegio
        {
 
            private string NombreCompleto;
            private int Edad;
            private string Sexo;
            private string Direccion;
            private string Curso;
            private string NumPadres;


            public EstudiantesColegio()
            {

                NombreCompleto = string.Empty;
                Edad = 0;
                Direccion = string.Empty;
                Curso = string.Empty;
                NumPadres = string.Empty;
            }

            public EstudiantesColegio(string nombreCompleto, int edad, string Sexo, string direccion, string Curso, string noTel)
            {
                this.NombreCompleto = nombreCompleto;
                this.Edad = edad;
                this.Sexo = Sexo;
                this.Direccion = direccion;
                this.Curso = Curso;
                this.NumPadres = noTel;
            }


            public string GetNombreCompleto()
            {
                return NombreCompleto;
            }
            public void SetNombreCompleto(string nombreCompleto)
            {
                this.NombreCompleto = nombreCompleto;
            }


            public int GetEdad()
            {
                return Edad;
            }
            public void SetEdad(int edad)
            {
                this.Edad = edad;
            }


            public string GetSexo()
            {
                return Sexo;
            }
            public void SetSexo(string Sexo)
            {
                this.Sexo = Sexo;
            }


            public string GetDireccion()
            {
                return Direccion;
            }
            public void SetDireccion(string direccion)
            {
                this.Direccion = direccion;
            }


            public string GetCurso()
            {
                return Curso;
            }
            public void SetCurso(string Curso)
            {
                this.Curso = Curso;
            }


            public string GetNumPadres()
            {
                return NumPadres;
            }
            public void SetNumPadres(string noTel)
            {
                this.NumPadres = noTel;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("\nNombre : {0}\nEdad: {1} años\nSexo: {2}\nDirección: {3}\nCurso: {4}\nNo. de Teléfono de sus Padres: {5}", NombreCompleto, Edad, Sexo, Direccion, Curso, NumPadres);
                return (sb.ToString());
            }
        }

        //EJERCICIO 3_4_5
        public class PoligonoString
        {

            private float Ancho;
            private float Largo;
            private float Alto;
            private float Radio;
            private float Lado;


            public PoligonoString(float ancho, float largo)
            {
                this.Ancho = ancho;
                this.Largo = largo;
            }


            public PoligonoString(float ancho, float largo, float alto)
            {
                this.Ancho = ancho;
                this.Largo = largo;
                this.Alto = alto;
            }


            public PoligonoString(float radio)
            {
                this.Radio = radio;
            }


            public float GetAncho()
            {
                return Ancho;
            }
            public void SetAncho(int ancho)
            {

                if (ancho <= 0)
                    Ancho = 1;
                else
                    this.Ancho = ancho;
            }

  
            public float GetLargo()
            {
                return Largo;
            }
            public void SetLargo(int largo)
            {

                if (largo <= 0)
                    Largo = 1;
                else
                    this.Largo = largo;
            }


            public float GetAlto()
            {
                return Alto;
            }
            public void SetAlto(int alto)
            {

                if (alto <= 0)
                    Alto = 1;
                else
                    this.Alto = alto;
            }


            public float GetRadio()
            {
                return Radio;
            }
            public void SetRadio(int radio)
            {

                if (radio <= 0)
                    Radio = 1;
                else
                    this.Radio = radio;
            }


            public float GetLado()
            {
                return Lado;
            }
            public void SetLado(int lado)
            {

                if (lado <= 0)
                    Lado = 1;
                else
                    this.Lado = lado;
            }

            public override string ToString()
            {
                String mensaje = "";
                mensaje += "Su ancho: " + Ancho.ToString() + "De largo" + Largo.ToString()
                + " De alto: " + Alto.ToString() + "De radio: " + Radio.ToString() + "De lado : " + Lado.ToString();
                return mensaje;
            }
        }
    }
}


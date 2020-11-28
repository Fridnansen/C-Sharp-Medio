using System;

namespace GenericosRestricciones62
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenEmpleados<Director> empleados = new AlmacenEmpleados<Director>(3);
            
            empleados.agregar(new Director(4500));

            empleados.agregar(new Director(4500));

            empleados.agregar(new Director(4500));

            Console.WriteLine("Hello World!");
        }
    }

    class AlmacenEmpleados<T> where T: IParaEmpleados
    {

        private int i = 0;

        private AlmacenEmpleados(int z)
        {

            datosEmpleado = new T[z];

        }

        public void agregar (T obj)
        {

            datosEmpleado[i] = obj;
            i++;

        }
        public T getEmpleados(int i)
        {

            return datosEmpleado[i];

        }

        private double[] datosEmpleado;
       
    }

    class Director : IParaEmpleados
    {

        public Director(double salario)
        {
            this.salario = salario; 
            
        }

        private double salario;

        public double getSalario()
        {

            return salario;

        }
    }

    class Secretaria : IParaEmpleados
    {
        public Secretaria(double salario)
        {
            this.salario = salario;

        }
        public double getSalario()
        {

            return salario;

        }
        private double salario;


    }

    class Electricista : IParaEmpleados
    {
        public Electricista(double salario)
        {
            this.salario = salario;

        }
        public double getSalario()
        {

            return salario;

        }

        private double salario;


    }

    class Estudiante
    {

        public Estudiante(double edad)
        {

            this.edad = edad;

        }

        private double edad;

    }

    interface IParaEmpleados
    {

        double getSalario();

    }
}


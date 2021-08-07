using Entidad;
using Logica;
using System;

namespace Presentacion
{
    class Program
    {
        static Servicio servicio = new Servicio();
        static Docentecs docente = new Docentecs();
        static Administrativo administrativo = new Administrativo();
        static Contratista contratista = new Contratista();
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            int opc;
            do
            {
                Console.WriteLine("1.Registrar");
                Console.WriteLine("2.Informe");
                Console.WriteLine("3.salir");

                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Registro();
                        break;
                    case 2:
                        informe();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo........");
                        break;


                }



            } while (opc != 3);

        }
        public static void Registro()
        {
            int opc;

            do
            {


                Console.WriteLine("1.Registrar Docente");
                Console.WriteLine("2.Registrar Administrativo");
                Console.WriteLine("3.Registrar contratista");
                Console.WriteLine("4.salir");

                opc = Convert.ToInt32(Console.ReadLine());

                if (opc.Equals(1))
                {
                    registroDocente();
                }
                else if (opc.Equals(2))
                {
                    registroAdministrativo();
                }
                else if (opc.Equals(3))
                {
                    registroContratista();
                }
            } while (opc == 3);
            Console.ReadKey();
        }

        public static void registroDocente()
        {
            string resp;

            do
            {


                Console.WriteLine("digite su id");
                docente.id = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su nombre");
                docente.nombre = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su apellido");
                docente.apellido = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su edad");
                docente.edad = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Dgite el valor pagado por horas");
                docente.valorhora = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el numero de horas dictadas");
                docente.horasdictadas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite la bonificacion");
                docente.bonificacion = Convert.ToInt32(Console.ReadLine());


                docente.calcularSueldo();

                string mensaje = servicio.GuardarPersona(docente );

                Console.WriteLine(mensaje);

                Console.WriteLine("Desea seguir registrando datos???");
                resp = Convert.ToString(Console.ReadLine());
                Console.ReadKey();

            } while (resp.Equals("si"));
        }
        public static void registroAdministrativo()
        {
            string resp;


            do
            {
                

                Console.WriteLine("digite su id");
                administrativo.id = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su nombre");
                administrativo.nombre = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su apellido");
                administrativo.apellido = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su edad");
                administrativo.edad = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su salario basico");
                administrativo.salariobasico = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el numero de horas extras");
                administrativo.hextras = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el numero de horas trabajadas");
                administrativo.diastrabajados = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el valor de los aportes");
                administrativo.aportes = Convert.ToInt32(Console.ReadLine());

                administrativo.calcularSueldo();

                string mensaje = servicio.GuardarPersona(administrativo);
                Console.WriteLine(mensaje);




                Console.WriteLine("Desea seguir registrandod datos???");
                resp = Convert.ToString(Console.ReadLine());

                Console.ReadKey();

            } while (resp.Equals("si"));

        }

        public static void registroContratista()
        {
            string resp;

            do
            {
               

                Console.WriteLine("digite su id");
                contratista.id = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su nombre");
                contratista.nombre = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su apellido");
                contratista.apellido = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su edad");
                contratista.edad = Convert.ToString(Console.ReadLine());


                Console.WriteLine("Digite el valor mensual");
                contratista.valormensual = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el numero de dias trabajados");
                contratista.diastrabajados = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el valor descontado");
                contratista.valordescontado = Convert.ToInt32(Console.ReadLine());

                contratista.calcularSueldo();

                string mensaje = servicio.GuardarPersona(contratista);
                Console.WriteLine(mensaje);


                Console.WriteLine("Desea seguir registrando datos????");
                resp = Convert.ToString(Console.ReadLine());



                Console.ReadKey();



            } while (resp.Equals("si"));
        }

        public static void informe()
        {
            int opc;
            Console.WriteLine("1.Informe Docente");
            Console.WriteLine("2.Informe Administrativo");
            Console.WriteLine("3.Informe contratista");
            Console.WriteLine("4.salir");

            opc = Convert.ToInt32(Console.ReadLine());


            if (opc.Equals(1))
            {
                informeDocente();
            }
            else if (opc.Equals(2))
            {
                informeAdministrativo();
            }
            else if (opc.Equals(3))
            {
                informeContratista();
            }
            Console.ReadKey();

        }

        public static void informeDocente()
        {

            Console.WriteLine("--------------------------------------");

            Console.WriteLine($"Identificacion :  {docente.id}");
            Console.WriteLine($"Nombre:   {docente.nombre}");
            Console.WriteLine($"Apellido:  {docente.apellido}");
            Console.WriteLine($"Valor por hora:  {docente.valorhora}");
            Console.WriteLine($"numero de horas dictadas: {docente.horasdictadas}");
            Console.WriteLine($"Bonificacion:  {docente.bonificacion}");
            Console.WriteLine($"el sueldo es de: { docente.sueldo}");




            Console.WriteLine("--------------------------------------");
            Console.ReadKey();

        }
        public static void informeAdministrativo()
        {


            Console.WriteLine("-------------------------------");

            Console.WriteLine($"Identificacion: {administrativo.id}");
            Console.WriteLine($"Nombre: {administrativo.nombre}");
            Console.WriteLine($"Apellido: {administrativo.apellido}");
            Console.WriteLine($"Salario basico: {administrativo.salariobasico}");
            Console.WriteLine($"Horas extras: {administrativo.hextras}");
            Console.WriteLine($"Dias trabajados: {administrativo.diastrabajados}");
            Console.WriteLine($"Aportes: {administrativo.aportes}");
            Console.WriteLine($"el sueldo es: {administrativo.sueldo}");

            Console.WriteLine("------------------------------------");
            Console.ReadKey();


        }

        public static void informeContratista()
        {
           
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Identificacion: { contratista.id}");
                Console.WriteLine($"Nombre: { contratista.nombre}");
                Console.WriteLine($"Apellido: {contratista.apellido}");
                Console.WriteLine($"Valor mensual: {contratista.valormensual}");
                Console.WriteLine($"Dias trabajados: {contratista.diastrabajados}");
                Console.WriteLine($"Valor descontado: {contratista.valordescontado}");

                Console.WriteLine($"El sueldo es: {contratista.sueldo}");

                Console.WriteLine("---------------------------------------");

            }
            Console.ReadKey();

        }

    }

}
    



    


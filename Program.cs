// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Collections.Generic;
using EspacioTarea;
using System.ComponentModel;

List <Tarea> TareasPendientes = new List<Tarea>();
List <Tarea> TareasRealizadas = new List<Tarea>();

Console.WriteLine("------------------CARGAR TAREA A LISTA PENDIENTE-------------------");
Console.WriteLine("Cargar Tarea SI(1) NO(0)");
if (!int.TryParse(Console.ReadLine(), out int respuesta))
{
    Console.WriteLine("El valor ingresado no es un numero");
}else{
    int min = 1, max = 10;
    Random rnd = new Random();
    int i=1;
    do{
        var tarea = new Tarea(i, "Descripcion " + i, rnd.Next(min, max + 1), estadoDeTarea.Pendiente);
        TareasPendientes.Add(tarea);
        Console.WriteLine("------------------CARGAR OTRA TAREA A LISTA PENDIENTE-------------------");
        Console.WriteLine("Cargar Tarea SI(1) NO(0)");
        if (!int.TryParse(Console.ReadLine(), out respuesta))
        {
            Console.WriteLine("El valor ingresado no es un numero");
        }
        i++;
    }while(respuesta!=0);
}



Console.WriteLine("-------------------MENU----------------");
Console.WriteLine("(1)Clasificar Tareas a Realizadas");
Console.WriteLine("(2)Mostrar Tareas Pendientes");
Console.WriteLine("(3)Mostrar las Tareas Realizadas");
Console.WriteLine("(4)Buscar una Tareas Pendientes por descripcion");
Console.WriteLine("Inserte respuesta: ");
if (!int.TryParse(Console.ReadLine(), out int opcion))
{
    Console.WriteLine("El valor ingresado no es numero");
}else{
    switch (opcion)
    {
        case 1:
        Console.WriteLine("---------Clasificar Tareas a Realizadas----------");
        foreach (var tarea in TareasPendientes)
        {
            Console.WriteLine(tarea.ShowTarea());
            Console.WriteLine("Tarea Realizada SI(1) NO(0)");
            if (!int.TryParse(Console.ReadLine(), out int op))
            {
                Console.WriteLine("El valor ingresado no es un numero");
            }else{
                if (op==1)
                {
                    idaMover= tarea.IdTarea;
                    moverTarea(TareasPendientes, TareasRealizadas, idaMover);
                    tarea.Estado= estadoDeTarea.Realizado;
                    TareasRealizadas.Add(tarea);
                    TareasPendientes.Remove(tarea);
                    Console.WriteLine("La tarea con ID "+ tarea.IdTarea + " se ha realizado");

                }
            }    
        }

        



        break;
        case 2:
        Console.WriteLine("---------Mostrar Tareas Pendientes----------");
        Console.WriteLine("ID  Descripcion      D    Estado");
        foreach (var tarea in TareasPendientes)
        {
            Console.WriteLine(tarea.ShowTarea());
        }

        break;
        case 3:
        Console.WriteLine("---------Mostrar Tareas Realizadas----------");
        Console.WriteLine("ID  Descripcion      D    Estado");
        foreach (var tarea in TareasRealizadas)
        {
            Console.WriteLine(tarea.ShowTarea());
        }
        break;
        case 4:
        Console.WriteLine("-------Buscar una Tarea Pendiente por descripcion-------");
        Console.WriteLine("Ingrese la descripcion a buscar: ");
        string descripcionBusc = Console.ReadLine();
        break;
        
        default:
        break;
    }
}



namespace EspacioTarea;

public class Tarea
{
    int idTarea;
    string descripcion;
    int duracion;
    estadoDeTarea estado;

    public Tarea(int id, string descripcion, int duracion, estadoDeTarea estado)
    {
        idTarea=id;
        this.descripcion=descripcion;
        this.duracion=duracion;
        this.estado = estado;
    }

    public int IdTarea { get => idTarea; set => idTarea = value; } //get lee y set asigna
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }
    internal estadoDeTarea Estado { get => estado; set => estado = value; }

    public string ShowTarea()
    {
        return IdTarea + " | " + Descripcion + " | " + Duracion + " | " + Estado;
    }

   
}

public enum estadoDeTarea
{
    Pendiente = 0,
    Realizado = 1
}


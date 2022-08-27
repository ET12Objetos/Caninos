namespace Biblioteca;

public class Perro
{
    public string raza { get; protected set; }
    public string nombre { get; protected set; }
    public double peso { get; protected set; }
    public double energia { get; protected set; }

    public Perro(string raza, string nombre, double peso, double energia)
    {
        this.raza = raza;
        this.nombre = nombre;
        this.peso = peso;
        this.energia = energia;
    }

    public string Informar() => $"Raza: {this.raza}, Nombre: {this.nombre}, Peso: {this.peso}";
}



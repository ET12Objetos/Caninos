namespace Biblioteca;

public abstract class Perro
{
    public string raza { get; protected set; }
    public string nombre { get; protected set; }
    public double peso { get; protected set; }
    public double energia { get; protected set; }

    public Perro(string nombre, double peso, double energia)
    {
        if (string.IsNullOrEmpty(nombre))
            throw new ArgumentOutOfRangeException("El nombre no puede ser cadena vacia");

        this.nombre = nombre;

        //validaciones
        if (peso > 0)
            this.peso = peso;
        else
            throw new ArgumentOutOfRangeException("El peso no puede ser negativo");

        if (energia <= 0)
            throw new ArgumentOutOfRangeException("La energia no puede ser negativa");

        this.energia = energia;

        this.raza = string.Empty;
    }

    public abstract void Correr();
    public abstract void Saltar();
    public string Informar() => $"Raza: {this.raza}, Nombre: {this.nombre}, Peso: {this.peso}";
}



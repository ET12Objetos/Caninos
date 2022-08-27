namespace Biblioteca;

public class SanBernardo : Perro
{
    public double altura { get; private set; }
    public SanBernardo(string raza, string nombre, double peso, double energia, double altura)
        : base(raza, nombre, peso, energia)
    {
        this.altura = altura;
    }

    public void Correr() => this.energia = this.energia - 0.1 * this.energia;
    public void Saltar() => this.energia = this.energia - 0.15 * this.energia;
    public void Rescatar() { }
}
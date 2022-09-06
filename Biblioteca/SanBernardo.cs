namespace Biblioteca;

public class SanBernardo : Perro
{
    public double altura { get; private set; }
    public SanBernardo(string nombre, double peso, double energia, double altura)
        : base(nombre, peso, energia)
    {
        //this.raza = "San Bernardo";
        this.raza = nameof(SanBernardo);

        //validacion
        if (altura <= 0)
            throw new ArgumentOutOfRangeException("Rango altura incorrecto");
        this.altura = altura;
    }

    public override void Correr() => this.energia = this.energia - 0.1 * this.energia;
    public override void Saltar() => this.energia = this.energia - 0.15 * this.energia;
    public void Rescatar() { }
}
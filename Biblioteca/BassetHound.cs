namespace Biblioteca;
public class BassetHound : Perro
{
    public BassetHound(string nombre, double peso, double energia)
        : base(nombre, peso, energia)
    {
        this.raza = nameof(BassetHound);
    }

    public override void Correr()
    {
        this.energia = this.energia - 0.2 * this.energia;
    }

    public override void Saltar()
    {
        this.energia = this.energia - 0.8 * this.energia;
    }
}
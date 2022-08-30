namespace Biblioteca;

public class HuskySiberiano : Perro
{
    public HuskySiberiano(string nombre, double peso, double energia)
        : base(nombre, peso, energia)
    {
        this.raza = nameof(HuskySiberiano);
    }

    public override void Correr() => this.energia = this.energia + 0.1 * this.energia;
    public override void Saltar() => this.energia = this.energia + 0.1 * this.energia;

    public void Arrastrar() { }
}
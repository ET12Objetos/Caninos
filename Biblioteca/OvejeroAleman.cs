namespace Biblioteca;

public class OvejeroAleman : Perro
{
    public OvejeroAleman(string nombre, double peso, double energia)
        : base(nombre, peso, energia)
    {
        this.raza = nameof(OvejeroAleman);
    }

    public override void Correr() => this.energia = this.energia + 0.2 * this.energia;
    public override void Saltar() => this.energia = this.energia - 0.05 * this.energia;
    public void Arrear() { }
}
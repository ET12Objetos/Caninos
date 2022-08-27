namespace Biblioteca;

public class OvejeroAleman : Perro
{
    public OvejeroAleman(string raza, string nombre, double peso, double energia)
        : base(raza, nombre, peso, energia)
    {

    }

    public void Correr() => this.energia = this.energia + 0.2 * this.energia;
    public void Saltar() => this.energia = this.energia - 0.05 * this.energia;
    public void Arrear() { }
}
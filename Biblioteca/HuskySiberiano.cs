namespace Biblioteca;

public class HuskySiberiano : Perro
{
    public HuskySiberiano(string raza, string nombre, double peso, double energia)
        : base(raza, nombre, peso, energia)
    {

    }

    public void Correr() => this.energia = this.energia + 0.1 * this.energia;

    public void Saltar() => this.energia = this.energia + 0.1 * this.energia;

    public void Arrastrar() { }
}
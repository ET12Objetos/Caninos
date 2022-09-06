using Biblioteca;

SanBernardo sanBernardo = new SanBernardo("Toby", 10, 39, 0);
sanBernardo.Correr();
sanBernardo.Saltar();
Console.WriteLine(sanBernardo.Informar());

HuskySiberiano huskySiberiano = new HuskySiberiano("Rex", 20, 35);
huskySiberiano.Correr();
huskySiberiano.Saltar();
Console.WriteLine(huskySiberiano.Informar());

OvejeroAleman ovejeroAleman = new OvejeroAleman("Charly", 63, 89);
ovejeroAleman.Correr();
ovejeroAleman.Saltar();
Console.WriteLine(ovejeroAleman.Informar());

BassetHound bassetHound = new BassetHound("Max", 33, 56);
bassetHound.Correr();
bassetHound.Saltar();
Console.WriteLine(bassetHound.Informar());


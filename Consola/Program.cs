using Biblioteca;

SanBernardo sanBernardo = new SanBernardo("SanBernardo", "Toby", 70, 39, 70);
sanBernardo.Correr();
sanBernardo.Saltar();
Console.WriteLine(sanBernardo.Informar());

HuskySiberiano huskySiberiano = new HuskySiberiano("HuskySiberiano", "Rex", 20, 35);
huskySiberiano.Correr();
huskySiberiano.Saltar();
Console.WriteLine(huskySiberiano.Informar());

OvejeroAleman ovejeroAleman = new OvejeroAleman("OvejeroAleman", "Charly", 63, 89);
ovejeroAleman.Correr();
ovejeroAleman.Saltar();
Console.WriteLine(ovejeroAleman.Informar());
using csharp_oop_shop;

Prodotto uova = new Prodotto(10, 20, "uova", "uovo");

double prezzo = uova.GetPrezzo();
Console.WriteLine("Il prezzo con iva è: " + prezzo + "euro");
uova.PrezzoSenzaIva();
Console.WriteLine("Il codice con il padding è: " + uova.GetCodice());
uova.NomeEsteso();


using DesafioPOO.Models;

Console.WriteLine("Nokia: ");
Nokia nokia = new("01234", "N12", "12121233", 512);
nokia.Numero = "323232";
nokia.InstalarAplicativo("Whatsapp");

nokia.DescricaoSmartphone();

Console.WriteLine("\nIphone: ");
Iphone iphone = new("43210", "15 Pro", "422332", 252);
iphone.InstalarAplicativo("Spotify");

iphone.DescricaoSmartphone();
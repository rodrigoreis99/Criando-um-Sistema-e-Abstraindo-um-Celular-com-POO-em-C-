using DesafioPOO.Models;

Smartphone nokia = new Nokia
    (
        "51995858877",
        "Aeros", 
        "000111", 
        128
    );
    
Smartphone iphone = new Iphone
    (
        "51981105178",
        "Mac", 
        "11000", 
        256
    );
    
Console.WriteLine(nokia);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.InstalarAplicativo("Facebook");
nokia.ReceberLigacao();

Console.WriteLine(iphone);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");
iphone.InstalarAplicativo("Facebook");
iphone.ReceberLigacao();

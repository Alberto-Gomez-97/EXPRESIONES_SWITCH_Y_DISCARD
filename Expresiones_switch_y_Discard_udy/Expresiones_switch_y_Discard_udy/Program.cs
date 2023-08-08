//EXPRESIONES SWITCH Y DISCARD

// se abrebian switch con una expresion de switch

var lugar = 1;
var mensaje = lugar switch
{
    1 => "Quedaste en primer lugar",
    2 => "Quedast en segundo lugar",
    3 => "Quedaste en tercer lugar",
    4 or 5 => "Casi lo logras",
    //DISCARD
    _ => "Mejor suerte la proxima"
};
Console.WriteLine(mensaje);

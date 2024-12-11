// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

float f = 12.5f;

double d = 130.78;

decimal dm = 1500.456m;

double ne = 5e-7;

//type inference  attraverso var lascia il compito di riconoscere il tipo di variabile attravesto la sua valorizzazione
//stringa
var s = "type inference";
//boolean
var b = false;


Console.WriteLine($"Float={f}, Double={d}, Decimal={dm}, Double scentifico={ne}, InferenzaSring={s}, InferenzaBool={b}");
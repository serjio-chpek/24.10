﻿using ConsoleApp4;

Vector3 vector = new Vector3(1, 2, 3);

//Cars audi = new Cars("Audi", vector);
//audi.Start();

//audi.Move(new Vector3(0, 6, 5));
//Console.WriteLine(audi.GetInfo());
//audi.Move(new Vector3(0, 6, 5));
//Console.WriteLine(audi.GetInfo());
//audi.Move(new Vector3(0, 6, 5));
//Console.WriteLine(audi.GetInfo());

// ключ для машин 0100
Cars bmw = new Cars("Bmw", vector);
bmw.Move(new Vector3(1, 3, 5));
bmw.CheckKey();
bmw.Start();

bmw.Move(new Vector3(1, 3, 5));
bmw.Move(new Vector3(1, 3, 5));
Console.WriteLine(bmw.GetInfo());
bmw.Start();
bmw.Off();
bmw.Off();

using System;

// https://www.w3schools.com/cs/cs_inheritance.php

class Program {
  public static void Main (string[] args) {
    Circulo fig1 = new Circulo(Colores.Azul, 3);
    Circulo fig2 = new Circulo(Colores.Rojo, 3);
    Rectangulo fig3 = new Rectangulo(Colores.Azul, 3, 2);
    Triangulo fig4 = new Triangulo(Colores.Verde, 3, 3, 3, 3);
    FiguraGeometrica[] figuras = {fig1, fig2, fig3, fig4};

    for(int i=0; i<4; i++){
      Console.WriteLine(figuras[i]);
    }

  }
}

enum Colores{
  Rojo, 
  Verde,
  Azul,
  Violeta
} 

abstract class FiguraGeometrica {
  public Colores Color {get; set;}
  public string Nombre {get; set;}

  public abstract double calcularArea();

  public abstract double calcularPerimetro();

  public override string ToString(){
    return $"{this.Nombre} - {this.Color} - de area: {this.calcularArea()} y perimetro: {this.calcularPerimetro()}";
  }
}

class Circulo: FiguraGeometrica {
  public double Radio {get; set;}

  public Circulo(Colores color, double radio){
    this.Color = color;
    this.Radio = radio;
    this.Nombre = "Circulo";
  }

  public override double calcularArea(){
    return Math.PI * this.Radio * this.Radio;
  }

  public override double calcularPerimetro(){
    return Math.PI * 2 * this.Radio;
  }

}

class Rectangulo: FiguraGeometrica {
  public double Base {get; set;}
  public double Altura {get; set;}

  public Rectangulo(Colores color, double _base, double altura){
    this.Color = color;
    this.Base = _base;
    this.Altura = altura;
    this.Nombre = "Rectangulo";
  }

  public override double calcularArea(){
    return this.Base * this.Altura;
  }

  public override double calcularPerimetro(){
    return 2 * this.Base + 2 * this.Altura;
  }
}

class Triangulo: FiguraGeometrica {
  public double Base {get; set;}
  public double Altura {get; set;}
  public double Lado1 {get; set;}
  public double Lado2 {get; set;}
  
  public Triangulo(Colores color, double _base, double altura, double lado1, double lado2){
    this.Color = color;
    this.Base = _base;
    this.Altura = altura;
    this.Lado1 = lado1;
    this.Lado2 = lado2;
    this.Nombre = "Triangulo";
  }

  public override double calcularArea(){
    return this.Base * this.Altura / 2;
  }

  public override double calcularPerimetro(){
    return this.Base + this.Lado1 + this.Lado2;
  }
}
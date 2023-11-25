using System;
using System.Drawing;

namespace HeritgeExercice;
public class House
{
    public double surface;
    public Door door;
    public double Surface { get; set; }
    public House(double surface,Door door)
    {
       this.surface= surface;
        this.door = door;
    }
    public virtual void Display()
    {
        Console.WriteLine("je suis un maison , ma surface est de " + this.surface + " m² "+"avec porte de couleur "+door.getColor());
    }
    
    public Door getDoor() {
        return door;
    }


}



public class Door
{
    public  string color;
    public string Color
    {
        get { return Color; }
        set { color = value; }
    }
   public Door(string c)
    {
        color = c;
    }

    public String getColor()
    {
        return color;
    }
  
    public string Display()
    {
        return (" je suis une porte , ma couleur est " + color);
    }



}




public class Apartement : House
{
    public double surfaceAppertement= 50;
   public Apartement(double surface,Door door):base(surface,door)
    {
      
    }
    
    public override void Display()
    {
        Console.WriteLine("je suis un Apartement de surface " + surfaceAppertement + "m²");
    }
    
}


public class Personne
{
    string nom;
    House house;
    public Personne(string nom, House house)
    {
        this.nom = nom;
        this.house = house;
    }
    public void Display()
    {
        Console.WriteLine("le nom de personne est " + nom + " avec maison de surface " + house.surface + " m² . "+"Avec une porte de couleur "+house.door.getColor());
       }
   
}


class test
{
    public static void Main(String[] args)
    {

        Door door = new Door("blue");
        House house = new House(30,door);
        Console.WriteLine("Fonction Display de House ");
        house.Display();
        Apartement appartement = new Apartement(30,door);
        Console.WriteLine("Fonction Display de Appartement ");
        appartement.Display();
         Personne person = new Personne("Louay", house);
        Console.WriteLine("Fonction Display de Personne ");
        person.Display();

    }
}

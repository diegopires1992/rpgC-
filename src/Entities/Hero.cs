using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.src.Entities
{
  public class Hero
  {
    public Hero(string Name, int Level, string HeroType, int Mp, int Hp)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
      this.Mp = Mp;
      this.Hp = Hp;
    }
    public Hero()
    {

    }
    public string Name { get; set; }
    public int Level { get; set; }
    public string HeroType { get; set; }
    public int Mp { get; set; }
    public int Hp { get; set; }

    public override string ToString()
    {
      return $"Name: {this.Name} Level: {this.Level} Class: {HeroType} MP: {Mp} HP: {Hp}";
    }

    public virtual string Attack()
    {
      return this.Name + " Atacou com uma espada";
    }

  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.src.Entities
{

  public class Ninja : Hero
  {
    public Ninja(string Name, int Level, string HeroType, int Mp, int Hp)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
      this.Mp = Mp;
      this.Hp = Hp;
    }

    public override string Attack()
    {
      return this.Name + " Atacou com uma espada";
    }
  }
}
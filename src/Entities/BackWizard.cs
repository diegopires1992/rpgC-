using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.src.Entities
{
  public class BackWizard : Hero
  {
    public BackWizard(string Name, int Level, string HeroType, int Mp, int Hp)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
      this.Mp = Mp;
      this.Hp = Hp;
    }

    public override string Attack()
    {
      return this.Name + " Atacou com uma bola de fogo";
    }

    public string Attack(int Bonus)
    {
      if (Bonus > 6)
      {
        return this.Name + " Lançou Magia Super com bonus de ataque de  " + Bonus;
      }
      else
      {
        return this.Name + " Lançou Magia com força fraca com bonus de  " + Bonus;
      }
    }

  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knite
{
    
    public class knite
    { 
        int maxHP; //макс ОЗ
        int currentHP; //текущий ОЗ
        int MxDmg; //макс урон
        int edmg = 7;
        int dmgbuff = 30;
        public int MaxHP
        {
            get { return maxHP; }
            set { maxHP = value; }
        }
        public int HP
        {
            get { return currentHP; }
            set { currentHP = maxHP; }
        }
        public int MaxDamage
        {
            get { return MxDmg; }
            set { MxDmg = value; }
        }
        public int Attack(int dmg) //метод для атаки 
        {
            Random random = new Random();
            dmg = random.Next(MxDmg / 2, MxDmg);
            dmg = dmg + dmg * dmgbuff;
            return dmg;
        }
        public int TakingDMG(int HP)
        {
            currentHP = currentHP - edmg;
            return currentHP;
        }
        public int TOA()
        {

            return dmgbuff;
        }
    }
}

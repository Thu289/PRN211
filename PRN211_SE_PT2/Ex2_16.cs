using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE_PT2
{
    internal class Ex2_16
    {
        class FlashLamp
        {
            bool status;
            Battery battery;

            public FlashLamp() 
            {
                status = false;
                battery = new Battery(0);
            }

            public int getBatteryInfo()
            {
                return battery.Energy;
            }

            public Battery Battery
            {
                get { return battery; }
                set { battery = value; }
            }

            public void turnOn()
            {
                status= true;
                if (battery.Energy > 0)
                {
                    Console.WriteLine("Den sang");
                }
                else Console.WriteLine("den ko sang");
            }

            public void turnOff()
            {
                status= false;
                Console.WriteLine("Den tat");
            }
        }

        class Battery
        {
            int energy;

            public Battery() 
            {
                energy = 10;
            }

            public int Energy
            {
                get { return energy; }
                set { energy = value; }
            }

            public Battery(int energy)
            {
                this.energy = energy;
            }

            public void decreaseEnergy()
            {
                energy -= 2;
            }

        }

        class TestFlashLamp
        {
            public static void Mains(string[] args)
            {
                Battery battery=new Battery();
                FlashLamp flashLamp=new FlashLamp();
                flashLamp.Battery= battery;
                for (int i=0; i<10; i++)
                {
                    flashLamp.turnOn();
                    flashLamp.turnOff();
                }
                int energy=flashLamp.getBatteryInfo();
                Console.WriteLine("Muc nang luong cua pin: ", energy);
            }
        }
    }
}
